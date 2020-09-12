﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp.UI.Lottie;
using Uno.Foundation.Extensibility;

#pragma warning disable 105
// Keep the space as this will not be replaced by the
// WinUI upgrade tool.
using Microsoft. UI.Xaml.Controls;
#pragma warning restore 105

[assembly: ApiExtension(typeof(ILottieVisualSourceProvider), typeof(Uno.UI.Lottie.LottieVisualSourceProvider))]

namespace Uno.UI.Lottie
{
	public class LottieVisualSourceProvider : ILottieVisualSourceProvider
	{
		public LottieVisualSourceProvider(object owner)
		{
		}

		public IAnimatedVisualSource CreateFromLottieAsset(Uri sourceFile) => new LottieVisualSource {UriSource = sourceFile};
	}
}
