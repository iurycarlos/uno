#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBindableObservableVector : global::Microsoft.UI.Xaml.Interop.IBindableVector,global::Microsoft.UI.Xaml.Interop.IBindableIterable
	{
		// Forced skipping of method Microsoft.UI.Xaml.Interop.IBindableObservableVector.VectorChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Interop.IBindableObservableVector.VectorChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Microsoft.UI.Xaml.Interop.BindableVectorChangedEventHandler VectorChanged;
		#endif
	}
}