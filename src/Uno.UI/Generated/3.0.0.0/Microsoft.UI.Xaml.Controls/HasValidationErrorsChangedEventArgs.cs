#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HasValidationErrorsChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool NewValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HasValidationErrorsChangedEventArgs.NewValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20HasValidationErrorsChangedEventArgs.NewValue");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.HasValidationErrorsChangedEventArgs.NewValue.get
	}
}