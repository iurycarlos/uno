#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RichEditBoxSelectionChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RichEditBoxSelectionChangingEventArgs.Cancel is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20RichEditBoxSelectionChangingEventArgs.Cancel");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs", "bool RichEditBoxSelectionChangingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int SelectionLength
		{
			get
			{
				throw new global::System.NotImplementedException("The member int RichEditBoxSelectionChangingEventArgs.SelectionLength is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20RichEditBoxSelectionChangingEventArgs.SelectionLength");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int SelectionStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member int RichEditBoxSelectionChangingEventArgs.SelectionStart is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20RichEditBoxSelectionChangingEventArgs.SelectionStart");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs.SelectionStart.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs.SelectionLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs.Cancel.set
	}
}