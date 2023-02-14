#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContextRequestedEventArgs : global::Microsoft.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContextRequestedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20ContextRequestedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.ContextRequestedEventArgs", "bool ContextRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ContextRequestedEventArgs() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.ContextRequestedEventArgs", "ContextRequestedEventArgs.ContextRequestedEventArgs()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Input.ContextRequestedEventArgs.ContextRequestedEventArgs()
		// Forced skipping of method Microsoft.UI.Xaml.Input.ContextRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.ContextRequestedEventArgs.Handled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool TryGetPosition( global::Microsoft.UI.Xaml.UIElement relativeTo, out global::Windows.Foundation.Point point)
		{
			throw new global::System.NotImplementedException("The member bool ContextRequestedEventArgs.TryGetPosition(UIElement relativeTo, out Point point) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20ContextRequestedEventArgs.TryGetPosition%28UIElement%20relativeTo%2C%20out%20Point%20point%29");
		}
		#endif
	}
}