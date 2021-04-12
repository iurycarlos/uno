#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using Uno.Extensions;
using Uno.Foundation;
using Uno.Foundation.Interop;
using Uno.Logging;
using Windows.Foundation.Collections;

namespace Windows.Storage
{
	public partial class ApplicationDataContainer
	{
		partial void InitializePartial(ApplicationData owner)
		{
			Values = new FilePropertySet(owner, Locality);
		}

		private class FilePropertySet : IPropertySet
		{
			private readonly ApplicationDataLocality _locality;
			private readonly ApplicationData _owner;

			public FilePropertySet(ApplicationData owner, ApplicationDataLocality locality)
			{
				_locality = locality;
				_owner = owner;

				ReadFromLegacyFile();
			}

			public object? this[string key]
			{
				get
				{
					if (ApplicationDataContainerInterop.TryGetValue(_locality, key, out var value))
					{
						return DataTypeSerializer.Deserialize(value);
					}
					return null;
				}
				set
				{
					if (value != null)
					{
						ApplicationDataContainerInterop.SetValue(_locality, key, DataTypeSerializer.Serialize(value));
					}
					else
					{
						Remove(key);
					}
				}
			}

			public ICollection<string> Keys
			{
				get
				{
					var keys = new List<string>();

					for (int i = 0; i < Count; i++)
					{
						keys.Add(ApplicationDataContainerInterop.GetKeyByIndex(_locality, i));
					}

					return keys.AsReadOnly();
				}
			}

			public ICollection<object> Values
			{
				get
				{
					var values = new List<object>();

					for (int i = 0; i < Count; i++)
					{
						var rawValue = ApplicationDataContainerInterop.GetValueByIndex(_locality, i);
						values.Add(DataTypeSerializer.Deserialize(rawValue));
					}

					return values.AsReadOnly();
				}
			}

			public int Count
				=> ApplicationDataContainerInterop.GetCount(_locality);

			public bool IsReadOnly => false;

			public event MapChangedEventHandler<string, object>? MapChanged;

			public void Add(string key, object value)
			{
				if (ContainsKey(key))
				{
					throw new ArgumentException("An item with the same key has already been added.");
				}
				if (value != null)
				{
					ApplicationDataContainerInterop.SetValue(_locality, key, DataTypeSerializer.Serialize(value));
					MapChanged?.Invoke(this, null);
				}
			}

			public void Add(KeyValuePair<string, object> item)
				=> Add(item.Key, item.Value);

			public void Clear()
			{
				ApplicationDataContainerInterop.Clear(_locality);
			}

			public bool Contains(KeyValuePair<string, object> item)
				=> throw new NotSupportedException();

			public bool ContainsKey(string key)
				=> ApplicationDataContainerInterop.ContainsKey(_locality, key);

			public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
				=> throw new NotSupportedException();

			public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
				=> throw new NotSupportedException();

			public bool Remove(string key)
			{
				var ret = ApplicationDataContainerInterop.Remove(_locality, key);
				return ret;
			}

			public bool Remove(KeyValuePair<string, object> item) => Remove(item.Key);

			public bool TryGetValue(string key, out object? value)
			{
				if (ApplicationDataContainerInterop.TryGetValue(_locality, key, out var innervalue))
				{
					value = DataTypeSerializer.Deserialize(innervalue);
					return true;
				}

				value = null;
				return false;
			}

			IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();

			private void ReadFromLegacyFile()
			{
				const string UWPFileName = ".UWPAppSettings";

				var folder = _locality switch
				{
					ApplicationDataLocality.Local => _owner.LocalFolder,
					ApplicationDataLocality.Roaming => _owner.RoamingFolder,
					ApplicationDataLocality.LocalCache => _owner.LocalCacheFolder,
					ApplicationDataLocality.Temporary => _owner.TemporaryFolder,
					_ => throw new ArgumentOutOfRangeException($"Unsupported locality {_locality}"),
				};

				var filePath = Path.Combine(folder.Path, UWPFileName);

				try
				{
					if (File.Exists(filePath))
					{
						using var reader = new BinaryReader(File.OpenRead(filePath));

						var count = reader.ReadInt32();

						if (this.Log().IsEnabled(LogLevel.Debug))
						{
							this.Log().Debug($"Reading {count} settings values");
						}

						for (var i = 0; i < count; i++)
						{
							var key = reader.ReadString();
							var value = reader.ReadString();

							this[key] = value;
						}
					}
					else
					{
						if (this.Log().IsEnabled(LogLevel.Debug))
						{
							this.Log().Debug($"File {filePath} does not exist, skipping reading legacy settings");
						}
					}
				}
				catch (Exception e)
				{
					if (this.Log().IsEnabled(LogLevel.Error))
					{
						this.Log().Error($"Failed to read settings from {filePath}", e);
					}
				}
			}
		}
	}

	class ApplicationDataContainerInterop
	{
		#region TryGetValue
		internal static bool TryGetValue(ApplicationDataLocality locality, string key, out string? value)
		{
			var parms = new ApplicationDataContainer_TryGetValueParams
			{
				Key = key,
				Locality = locality.ToStringInvariant()
			};

			var ret = ApplicationDataContainer_TryGetValueReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:tryGetValue", parms, ret);

			value = ret.Value.Value;

			return ret.Value.HasValue;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_TryGetValueParams
		{
			public string Key;
			public string Locality;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_TryGetValueReturn_Wrapper
		{
			public static ApplicationDataContainer_TryGetValueReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_TryGetValueReturn_Wrapper();

			private ApplicationDataContainer_TryGetValueReturn_Wrapper() { }

			public ApplicationDataContainer_TryGetValueReturn Value;

		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_TryGetValueReturn
		{
			public string? Value;
			public bool HasValue;
		}
		#endregion

		#region SetValue
		internal static void SetValue(ApplicationDataLocality locality, string key, string value)
		{
			var parms = new ApplicationDataContainer_SetValueParams
			{
				Key = key,
				Value = value,
				Locality = locality.ToStringInvariant()
			};

			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:setValue", parms);
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_SetValueParams
		{
			public string Key;
			public string Value;
			public string Locality;
		}

		#endregion

		#region ContainsKey
		internal static bool ContainsKey(ApplicationDataLocality locality, string key)
		{
			var parms = new ApplicationDataContainer_ContainsKeyParams
			{
				Key = key,
				Locality = locality.ToStringInvariant()
			};

			var ret = ApplicationDataContainer_ContainsKeyReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:containsKey", parms, ret);
			return ret.Value.ContainsKey;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_ContainsKeyParams
		{
			public string Key;
			public string Value;
			public string Locality;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_ContainsKeyReturn_Wrapper
		{
			public static ApplicationDataContainer_ContainsKeyReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_ContainsKeyReturn_Wrapper();

			private ApplicationDataContainer_ContainsKeyReturn_Wrapper() { }

			public ApplicationDataContainer_ContainsKeyReturn Value;

		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_ContainsKeyReturn
		{
			public bool ContainsKey;
		}
		#endregion

		#region GetKeyByIndex
		internal static string GetKeyByIndex(ApplicationDataLocality locality, int index)
		{
			var parms = new ApplicationDataContainer_GetKeyByIndexParams
			{
				Locality = locality.ToStringInvariant(),
				Index = index
			};

			var ret = ApplicationDataContainer_GetKeyByIndexReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:getKeyByIndex", parms, ret);

			return ret.Value.Value!;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_GetKeyByIndexParams
		{
			public string Locality;
			public int Index;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_GetKeyByIndexReturn_Wrapper
		{
			public static ApplicationDataContainer_GetKeyByIndexReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_GetKeyByIndexReturn_Wrapper();

			private ApplicationDataContainer_GetKeyByIndexReturn_Wrapper() { }

			public ApplicationDataContainer_GetKeyByIndexReturn Value;

		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_GetKeyByIndexReturn
		{
			public string Value;
		}
		#endregion

		#region GetCount

		internal static int GetCount(ApplicationDataLocality locality)
		{
			var parms = new ApplicationDataContainer_GetCountParams
			{
				Locality = locality.ToStringInvariant()
			};

			var ret = ApplicationDataContainer_GetCountReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:getCount", parms, ret);
			return ret.Value.Count;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_GetCountParams
		{
			public string Locality;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_GetCountReturn
		{
			public int Count;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_GetCountReturn_Wrapper
		{
			public static ApplicationDataContainer_GetCountReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_GetCountReturn_Wrapper();

			private ApplicationDataContainer_GetCountReturn_Wrapper() { }

			public ApplicationDataContainer_GetCountReturn Value;
		}
		#endregion

		#region Clear

		internal static void Clear(ApplicationDataLocality locality)
		{
			var parms = new ApplicationDataContainer_ClearParams
			{
				Locality = locality.ToStringInvariant()
			};

			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:clear", parms);
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_ClearParams
		{
			public string Locality;
		}

		#endregion

		#region Remove

		internal static bool Remove(ApplicationDataLocality locality, string key)
		{
			var parms = new ApplicationDataContainer_RemoveParams
			{
				Locality = locality.ToStringInvariant(),
				Key = key
			};

			var ret = ApplicationDataContainer_RemoveReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:remove", parms, ret);
			return ret.Value.Removed;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_RemoveParams
		{
			public string Locality;
			public string Key;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_RemoveReturn_Wrapper
		{
			public static ApplicationDataContainer_RemoveReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_RemoveReturn_Wrapper();

			private ApplicationDataContainer_RemoveReturn_Wrapper() { }

			public ApplicationDataContainer_RemoveReturn Value;

		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ApplicationDataContainer_RemoveReturn
		{
			public bool Removed;
		}

		#endregion

		#region GetValueByIndex

		internal static string GetValueByIndex(ApplicationDataLocality locality, int index)
		{
			var parms = new ApplicationDataContainer_GetValueByIndexParams
			{
				Locality = locality.ToStringInvariant(),
				Index = index
			};

			var ret = ApplicationDataContainer_GetValueByIndexReturn_Wrapper.Instance;
			TSInteropMarshaller.InvokeJS("UnoStatic_Windows_Storage_ApplicationDataContainer:getValueByIndex", parms, ret);

			return ret.Value.Value!;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct ApplicationDataContainer_GetValueByIndexParams
		{
			public string Locality;
			public int Index;
		}

		[StructLayout(LayoutKind.Sequential)]
		private class ApplicationDataContainer_GetValueByIndexReturn_Wrapper
		{
			public static ApplicationDataContainer_GetValueByIndexReturn_Wrapper Instance { get; }
				= new ApplicationDataContainer_GetValueByIndexReturn_Wrapper();

			private ApplicationDataContainer_GetValueByIndexReturn_Wrapper() { }

			public ApplicationDataContainer_GetValueByIndexReturn Value;
		}

		[TSInteropMessage]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ApplicationDataContainer_GetValueByIndexReturn
		{
			public string Value;
		}
		#endregion
	}
}