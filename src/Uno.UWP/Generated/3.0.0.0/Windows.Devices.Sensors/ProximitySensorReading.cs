#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ProximitySensorReading 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint? DistanceInMillimeters
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ProximitySensorReading.DistanceInMillimeters is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%3F%20ProximitySensorReading.DistanceInMillimeters");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsDetected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ProximitySensorReading.IsDetected is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20ProximitySensorReading.IsDetected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ProximitySensorReading.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20ProximitySensorReading.Timestamp");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensorReading.Timestamp.get
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensorReading.IsDetected.get
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensorReading.DistanceInMillimeters.get
	}
}
