#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FullScreenPresenter : global::Microsoft.UI.Windowing.AppWindowPresenter
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.FullScreenPresenter Create()
		{
			throw new global::System.NotImplementedException("The member FullScreenPresenter FullScreenPresenter.Create() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=FullScreenPresenter%20FullScreenPresenter.Create%28%29");
		}
		#endif
	}
}