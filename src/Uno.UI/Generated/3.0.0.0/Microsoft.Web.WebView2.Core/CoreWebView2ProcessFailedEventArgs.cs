#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2ProcessFailedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind ProcessFailedKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2ProcessFailedKind CoreWebView2ProcessFailedEventArgs.ProcessFailedKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWebView2ProcessFailedKind%20CoreWebView2ProcessFailedEventArgs.ProcessFailedKind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ExitCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CoreWebView2ProcessFailedEventArgs.ExitCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20CoreWebView2ProcessFailedEventArgs.ExitCode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> FrameInfosForFailedProcess
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<CoreWebView2FrameInfo> CoreWebView2ProcessFailedEventArgs.FrameInfosForFailedProcess is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CCoreWebView2FrameInfo%3E%20CoreWebView2ProcessFailedEventArgs.FrameInfosForFailedProcess");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProcessDescription
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ProcessFailedEventArgs.ProcessDescription is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20CoreWebView2ProcessFailedEventArgs.ProcessDescription");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2ProcessFailedReason CoreWebView2ProcessFailedEventArgs.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWebView2ProcessFailedReason%20CoreWebView2ProcessFailedEventArgs.Reason");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.Reason.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ExitCode.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessDescription.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.FrameInfosForFailedProcess.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs.ProcessFailedKind.get
	}
}