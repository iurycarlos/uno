#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Window 
	{
		// Skipping already declared property Content
		// Skipping already declared property Bounds
		// Skipping already declared property CoreWindow
		// Skipping already declared property Dispatcher
		// Skipping already declared property Visible
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Compositor Compositor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Compositor Window.Compositor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Compositor%20Window.Compositor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.UIContext UIContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIContext Window.UIContext is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIContext%20Window.UIContext");
			}
		}
		#endif
		// Skipping already declared property Current
		// Forced skipping of method Windows.UI.Xaml.Window.Bounds.get
		// Forced skipping of method Windows.UI.Xaml.Window.Visible.get
		// Forced skipping of method Windows.UI.Xaml.Window.Content.get
		// Forced skipping of method Windows.UI.Xaml.Window.Content.set
		// Forced skipping of method Windows.UI.Xaml.Window.CoreWindow.get
		// Forced skipping of method Windows.UI.Xaml.Window.Dispatcher.get
		// Forced skipping of method Windows.UI.Xaml.Window.Activated.add
		// Forced skipping of method Windows.UI.Xaml.Window.Activated.remove
		// Forced skipping of method Windows.UI.Xaml.Window.Closed.add
		// Forced skipping of method Windows.UI.Xaml.Window.Closed.remove
		// Forced skipping of method Windows.UI.Xaml.Window.SizeChanged.add
		// Forced skipping of method Windows.UI.Xaml.Window.SizeChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Window.VisibilityChanged.add
		// Forced skipping of method Windows.UI.Xaml.Window.VisibilityChanged.remove
		// Skipping already declared method Windows.UI.Xaml.Window.Activate()
		// Skipping already declared method Windows.UI.Xaml.Window.Close()
		// Skipping already declared method Windows.UI.Xaml.Window.SetTitleBar(Windows.UI.Xaml.UIElement)
		// Forced skipping of method Windows.UI.Xaml.Window.Compositor.get
		// Forced skipping of method Windows.UI.Xaml.Window.UIContext.get
		// Forced skipping of method Windows.UI.Xaml.Window.Current.get
		// Skipping already declared event Windows.UI.Xaml.Window.Activated
		// Skipping already declared event Windows.UI.Xaml.Window.Closed
		// Skipping already declared event Windows.UI.Xaml.Window.SizeChanged
		// Skipping already declared event Windows.UI.Xaml.Window.VisibilityChanged
	}
}
