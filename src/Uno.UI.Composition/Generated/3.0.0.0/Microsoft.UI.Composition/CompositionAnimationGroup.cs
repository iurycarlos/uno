#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionAnimationGroup : global::Microsoft.UI.Composition.CompositionObject,global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Composition.CompositionAnimation>,global::Microsoft.UI.Composition.ICompositionAnimationBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Count
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CompositionAnimationGroup.Count is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20CompositionAnimationGroup.Count");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionAnimationGroup.First()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Add( global::Microsoft.UI.Composition.CompositionAnimation value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.Add(CompositionAnimation value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Remove( global::Microsoft.UI.Composition.CompositionAnimation value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.Remove(CompositionAnimation value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RemoveAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionAnimationGroup", "void CompositionAnimationGroup.RemoveAll()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionAnimationGroup.Count.get
		// Processing: System.Collections.Generic.IEnumerable<Microsoft.UI.Composition.CompositionAnimation>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Microsoft.UI.Composition.CompositionAnimation>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IEnumerator<global::Microsoft.UI.Composition.CompositionAnimation> GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: System.Collections.IEnumerable
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.IEnumerable
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		 global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: Microsoft.UI.Composition.ICompositionAnimationBase
	}
}