﻿#if __WASM__ || __MACOS__
#pragma warning disable CS0067, CS0414
#endif

#if XAMARIN || __WASM__ || __SKIA__
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno;

namespace Windows.UI.Xaml.Controls
{
#if __WASM__ || __SKIA__
	[NotImplemented("__WASM__", "__SKIA__")]
#endif
	public partial class WebView : Control
	{
		private const string BlankUrl = "about:blank";
		private static readonly Uri BlankUri = new Uri(BlankUrl);

		private object _internalSource;
		private bool _isUpdatingSource;

#pragma warning disable CS0414 // not used in skia
		private bool _isLoaded;
#pragma warning restore CS0414

		public WebView()
		{
			DefaultStyleKey = typeof(WebView);
		}

		#region CanGoBack

		public bool CanGoBack
		{
			get { return (bool)GetValue(CanGoBackProperty); }
			private set { SetValue(CanGoBackProperty, value); }
		}

		public static DependencyProperty CanGoBackProperty { get; } =
			DependencyProperty.Register("CanGoBack", typeof(bool), typeof(WebView), new FrameworkPropertyMetadata(false));

		#endregion

		#region CanGoForward

		public bool CanGoForward
		{
			get { return (bool)GetValue(CanGoForwardProperty); }
			private set { SetValue(CanGoForwardProperty, value); }
		}

		public static DependencyProperty CanGoForwardProperty { get; } =
			DependencyProperty.Register("CanGoForward", typeof(bool), typeof(WebView), new FrameworkPropertyMetadata(false));

		#endregion

		#region Source

		public Uri Source
		{
			get { return (Uri)GetValue(SourceProperty); }
			set { SetValue(SourceProperty, value); }
		}

		public static DependencyProperty SourceProperty { get; } =
			DependencyProperty.Register("Source", typeof(Uri), typeof(WebView), new FrameworkPropertyMetadata(null,
				(s, e) => ((WebView)s)?.Navigate((Uri)e.NewValue)));

		#endregion

#if __ANDROID__ || __IOS__ || __MACOS__
		#region DocumentTitle
		public string DocumentTitle
		{
			get { return (string)GetValue(DocumentTitleProperty); }
			internal set { SetValue(DocumentTitleProperty, value); }
		}

		public static DependencyProperty DocumentTitleProperty { get; } =
			DependencyProperty.Register(nameof(DocumentTitle), typeof(string), typeof(WebView), new FrameworkPropertyMetadata(null));
		#endregion
#endif

		#region IsScrollEnabled
		public bool IsScrollEnabled
		{
			get { return (bool)GetValue(IsScrollEnabledProperty); }
			set { SetValue(IsScrollEnabledProperty, value); }
		}

		public static DependencyProperty IsScrollEnabledProperty { get; } =
			DependencyProperty.Register("IsScrollEnabled", typeof(bool), typeof(WebView), new FrameworkPropertyMetadata(true,
				(s, e) => ((WebView)s)?.OnScrollEnabledChangedPartial((bool)e.NewValue)));

		partial void OnScrollEnabledChangedPartial(bool scrollingEnabled);
		#endregion

#pragma warning disable 67
		public event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> NavigationStarting;
		public event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> NavigationCompleted;
		public event TypedEventHandler<WebView, WebViewNewWindowRequestedEventArgs> NewWindowRequested;
		public event TypedEventHandler<WebView, WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;
#pragma warning restore 67

		//Remove pragma when implemented for Android
#pragma warning disable 0067
		public event WebViewNavigationFailedEventHandler NavigationFailed;
#pragma warning restore 0067

		public void GoBack()
		{
			GoBackPartial();
		}

		public void GoForward()
		{
			GoForwardPartial();
		}

		public void Navigate(Uri uri)
		{
			if (_isUpdatingSource)
			{
				// This avoids Stackoverflow. When Navigate is called, we end up setting Source property, and the property changed callback for SourceProperty is Navigate.
				// So this breaks the cycle (Navigate → set_Source → Navigate → ...)
				return;
			}
			this.SetInternalSource(uri ?? BlankUri);
		}

		//
		// Summary:
		//     Loads the specified HTML content as a new document.
		//
		// Parameters:
		//   text:
		//     The HTML content to display in the WebView control.
		public void NavigateToString(string text)
		{
			this.SetInternalSource(text ?? "");
		}

		public void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage)
		{
			if (requestMessage?.RequestUri == null)
			{
				throw new ArgumentException("Invalid request message. It does not have a RequestUri.");
			}

			SetInternalSource(requestMessage);
		}

		public void Stop()
		{
			StopPartial();
		}

		partial void GoBackPartial();
		partial void GoForwardPartial();
		partial void NavigatePartial(Uri uri);
		partial void NavigateToStringPartial(string text);
		partial void NavigateWithHttpRequestMessagePartial(HttpRequestMessage requestMessage);
		partial void StopPartial();

		private protected override void OnLoaded()
		{
			base.OnLoaded();

			_isLoaded = true;
		}

		private void SetInternalSource(object source)
		{
			_internalSource = source;

			this.UpdateFromInternalSource();
		}

		private void UpdateFromInternalSource()
		{
			if (_internalSource is Uri uri)
			{
				_isUpdatingSource = true;
				Source = new Uri(uri.ToString());
				_isUpdatingSource = false;
				NavigatePartial(uri);
			}
			else if (_internalSource is string html)
			{
				_isUpdatingSource = true;
				Source = null;
				_isUpdatingSource = false;
				NavigateToStringPartial(html);
			}
			else if (_internalSource is HttpRequestMessage message)
			{
				_isUpdatingSource = true;
				Source = new Uri(message.RequestUri.ToString());
				_isUpdatingSource = false;
				NavigateWithHttpRequestMessagePartial(message);
			}
		}

		private static string ConcatenateJavascriptArguments(string[] arguments)
		{
			var argument = string.Empty;
			if (arguments != null && arguments.Any())
			{
				argument = string.Join(",", arguments);
			}

			return argument;
		}

		internal void OnUnsupportedUriSchemeIdentified(WebViewUnsupportedUriSchemeIdentifiedEventArgs args)
		{
			UnsupportedUriSchemeIdentified?.Invoke(this, args);
		}

		internal bool GetIsHistoryEntryValid(string url) => !url.IsNullOrWhiteSpace() && !url.Equals(BlankUrl, StringComparison.OrdinalIgnoreCase);
	}
}
#endif
