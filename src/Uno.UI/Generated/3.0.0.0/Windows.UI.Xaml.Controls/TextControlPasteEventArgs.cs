#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextControlPasteEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TextControlPasteEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20TextControlPasteEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TextControlPasteEventArgs", "bool TextControlPasteEventArgs.Handled");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextControlPasteEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextControlPasteEventArgs.Handled.set
	}
}
