#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BounceScalarNaturalMotionAnimation : global::Microsoft.UI.Composition.ScalarNaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Restitution
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceScalarNaturalMotionAnimation.Restitution is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20BounceScalarNaturalMotionAnimation.Restitution");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation", "float BounceScalarNaturalMotionAnimation.Restitution");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Acceleration
		{
			get
			{
				throw new global::System.NotImplementedException("The member float BounceScalarNaturalMotionAnimation.Acceleration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20BounceScalarNaturalMotionAnimation.Acceleration");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation", "float BounceScalarNaturalMotionAnimation.Acceleration");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Restitution.set
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Acceleration.get
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Acceleration.set
		// Forced skipping of method Microsoft.UI.Composition.BounceScalarNaturalMotionAnimation.Restitution.get
	}
}