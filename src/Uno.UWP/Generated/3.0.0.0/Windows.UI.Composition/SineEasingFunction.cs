#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SineEasingFunction : global::Windows.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionEasingFunctionMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEasingFunctionMode SineEasingFunction.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionEasingFunctionMode%20SineEasingFunction.Mode");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.SineEasingFunction.Mode.get
	}
}