#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Data
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INotifyDataErrorInfo 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool HasErrors
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.HasErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.ErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.ErrorsChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::System.Collections.Generic.IEnumerable<object> GetErrors( string propertyName);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::System.EventHandler<global::Microsoft.UI.Xaml.Data.DataErrorsChangedEventArgs> ErrorsChanged;
		#endif
	}
}