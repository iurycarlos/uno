#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarCustomPen : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected InkToolbarCustomPen() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarCustomPen", "InkToolbarCustomPen.InkToolbarCustomPen()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarCustomPen.InkToolbarCustomPen()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributes( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributes(Brush brush, double strokeWidth) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InkDrawingAttributes%20InkToolbarCustomPen.CreateInkDrawingAttributes%28Brush%20brush%2C%20double%20strokeWidth%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual global::Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributesCore( global::Windows.UI.Xaml.Media.Brush brush,  double strokeWidth)
		{
			throw new global::System.NotImplementedException("The member InkDrawingAttributes InkToolbarCustomPen.CreateInkDrawingAttributesCore(Brush brush, double strokeWidth) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InkDrawingAttributes%20InkToolbarCustomPen.CreateInkDrawingAttributesCore%28Brush%20brush%2C%20double%20strokeWidth%29");
		}
		#endif
	}
}
