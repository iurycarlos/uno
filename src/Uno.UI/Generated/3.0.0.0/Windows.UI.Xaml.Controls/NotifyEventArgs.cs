#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NotifyEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string NotifyEventArgs.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20NotifyEventArgs.Value");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri CallingUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri NotifyEventArgs.CallingUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20NotifyEventArgs.CallingUri");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.NotifyEventArgs.Value.get
		// Forced skipping of method Windows.UI.Xaml.Controls.NotifyEventArgs.CallingUri.get
	}
}
