﻿using System;
using Windows.System;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
	partial class UIElement
	{
#if __NETSTD__
		internal bool IsInLiveTree => IsLoading || IsLoaded;
#elif __ANDROID__
		internal bool IsInLiveTree => base.IsAttachedToWindow;
#elif __IOS__ || __MACOS__
		internal bool IsInLiveTree => base.Window != null;
#else
		internal bool IsInLiveTree => throw new NotSupportedException();
#endif

#if !__NETSTD__
		internal void RemoveChild(UIElement viewToRemove) => VisualTreeHelper.RemoveChild(this, viewToRemove);

		internal void AddChild(UIElement viewToAdd) => VisualTreeHelper.AddChild(this, viewToAdd);

		internal UIElement ReplaceChild(int index, UIElement viewToRemove) => VisualTreeHelper.ReplaceChild(this, index, viewToRemove);
#endif

#if !HAS_UNO_WINUI
		// This is to ensure forward compatibility with WinUI
		private protected DispatcherQueue DispatcherQueue => DispatcherQueue.GetForCurrentThread();
#endif
	}
}
