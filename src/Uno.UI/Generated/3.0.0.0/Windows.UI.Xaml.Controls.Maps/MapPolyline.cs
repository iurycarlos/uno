#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapPolyline : global::Windows.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double StrokeThickness
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MapPolyline.StrokeThickness is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20MapPolyline.StrokeThickness");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolyline", "double MapPolyline.StrokeThickness");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool StrokeDashed
		{
			get
			{
				return (bool)this.GetValue(StrokeDashedProperty);
			}
			set
			{
				this.SetValue(StrokeDashedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color StrokeColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapPolyline.StrokeColor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Color%20MapPolyline.StrokeColor");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolyline", "Color MapPolyline.StrokeColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Geolocation.Geopath Path
		{
			get
			{
				return (global::Windows.Devices.Geolocation.Geopath)this.GetValue(PathProperty);
			}
			set
			{
				this.SetValue(PathProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PathProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Path), typeof(global::Windows.Devices.Geolocation.Geopath), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapPolyline), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopath)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeDashedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeDashed), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapPolyline), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapPolyline() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolyline", "MapPolyline.MapPolyline()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.MapPolyline()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.Path.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.Path.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeThickness.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeThickness.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashed.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashed.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.PathProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashedProperty.get
	}
}
