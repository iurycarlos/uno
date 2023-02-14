#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class TimePicker : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  global::System.TimeSpan Time
		{
			get
			{
				return (global::System.TimeSpan)this.GetValue(TimeProperty);
			}
			set
			{
				this.SetValue(TimeProperty, value);
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  global::System.TimeSpan? SelectedTime
		{
			get
			{
				return (global::System.TimeSpan?)this.GetValue(SelectedTimeProperty);
			}
			set
			{
				this.SetValue(SelectedTimeProperty, value);
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  int MinuteIncrement
		{
			get
			{
				return (int)this.GetValue(MinuteIncrementProperty);
			}
			set
			{
				this.SetValue(MinuteIncrementProperty, value);
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)this.GetValue(LightDismissOverlayModeProperty);
			}
			set
			{
				this.SetValue(LightDismissOverlayModeProperty, value);
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  global::Microsoft.UI.Xaml.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(HeaderTemplateProperty);
			}
			set
			{
				this.SetValue(HeaderTemplateProperty, value);
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  object Header
		{
			get
			{
				return (object)this.GetValue(HeaderProperty);
			}
			set
			{
				this.SetValue(HeaderProperty, value);
			}
		}
		#endif
		// Skipping already declared property ClockIdentifier
		// Skipping already declared property ClockIdentifierProperty
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HeaderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Header), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(object)));
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HeaderTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HeaderTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty LightDismissOverlayModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(LightDismissOverlayMode), typeof(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)));
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinuteIncrementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinuteIncrement), typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedTimeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedTime), typeof(global::System.TimeSpan?), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(global::System.TimeSpan?)));
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TimeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Time), typeof(global::System.TimeSpan), 
			typeof(global::Microsoft.UI.Xaml.Controls.TimePicker), 
			new FrameworkPropertyMetadata(default(global::System.TimeSpan)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.TimePicker.TimePicker()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.TimePicker()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.ClockIdentifier.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.ClockIdentifier.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.MinuteIncrement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.MinuteIncrement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.Time.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.Time.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.LightDismissOverlayMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.LightDismissOverlayMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.SelectedTime.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.SelectedTime.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.TimeChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.TimeChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.SelectedTimeChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.SelectedTimeChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.ClockIdentifierProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.MinuteIncrementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.TimeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.LightDismissOverlayModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TimePicker.SelectedTimeProperty.get
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TimePicker, global::Microsoft.UI.Xaml.Controls.TimePickerSelectedValueChangedEventArgs> SelectedTimeChanged
		{
			[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TimePicker", "event TypedEventHandler<TimePicker, TimePickerSelectedValueChangedEventArgs> TimePicker.SelectedTimeChanged");
			}
			[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TimePicker", "event TypedEventHandler<TimePicker, TimePickerSelectedValueChangedEventArgs> TimePicker.SelectedTimeChanged");
			}
		}
		#endif
		#if false || false || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public  event global::System.EventHandler<global::Microsoft.UI.Xaml.Controls.TimePickerValueChangedEventArgs> TimeChanged
		{
			[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TimePicker", "event EventHandler<TimePickerValueChangedEventArgs> TimePicker.TimeChanged");
			}
			[global::Uno.NotImplemented("__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TimePicker", "event EventHandler<TimePickerValueChangedEventArgs> TimePicker.TimeChanged");
			}
		}
		#endif
	}
}