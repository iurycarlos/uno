#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComboBoxTextSubmittedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ComboBoxTextSubmittedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20ComboBoxTextSubmittedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs", "bool ComboBoxTextSubmittedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ComboBoxTextSubmittedEventArgs.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ComboBoxTextSubmittedEventArgs.Text");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs.Text.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs.Handled.set
	}
}
