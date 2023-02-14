#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInteractionTrackerOwner 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void CustomAnimationStateEntered( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerCustomAnimationStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void IdleStateEntered( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerIdleStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void InertiaStateEntered( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void InteractingStateEntered( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerInteractingStateEnteredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void RequestIgnored( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerRequestIgnoredArgs args);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void ValuesChanged( global::Microsoft.UI.Composition.Interactions.InteractionTracker sender,  global::Microsoft.UI.Composition.Interactions.InteractionTrackerValuesChangedArgs args);
		#endif
	}
}