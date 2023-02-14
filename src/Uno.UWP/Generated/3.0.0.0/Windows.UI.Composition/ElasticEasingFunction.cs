#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ElasticEasingFunction : global::Windows.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionEasingFunctionMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEasingFunctionMode ElasticEasingFunction.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionEasingFunctionMode%20ElasticEasingFunction.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Oscillations
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ElasticEasingFunction.Oscillations is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20ElasticEasingFunction.Oscillations");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Springiness
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ElasticEasingFunction.Springiness is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20ElasticEasingFunction.Springiness");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.ElasticEasingFunction.Mode.get
		// Forced skipping of method Windows.UI.Composition.ElasticEasingFunction.Oscillations.get
		// Forced skipping of method Windows.UI.Composition.ElasticEasingFunction.Springiness.get
	}
}