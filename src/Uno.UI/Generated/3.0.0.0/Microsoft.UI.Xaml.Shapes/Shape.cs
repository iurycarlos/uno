#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Shapes
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Shape : global::Microsoft.UI.Xaml.FrameworkElement
	{
		// Skipping already declared property StrokeThickness
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.PenLineCap StrokeStartLineCap
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeStartLineCapProperty);
			}
			set
			{
				this.SetValue(StrokeStartLineCapProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double StrokeMiterLimit
		{
			get
			{
				return (double)this.GetValue(StrokeMiterLimitProperty);
			}
			set
			{
				this.SetValue(StrokeMiterLimitProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.PenLineJoin StrokeLineJoin
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.PenLineJoin)this.GetValue(StrokeLineJoinProperty);
			}
			set
			{
				this.SetValue(StrokeLineJoinProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.PenLineCap StrokeEndLineCap
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeEndLineCapProperty);
			}
			set
			{
				this.SetValue(StrokeEndLineCapProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double StrokeDashOffset
		{
			get
			{
				return (double)this.GetValue(StrokeDashOffsetProperty);
			}
			set
			{
				this.SetValue(StrokeDashOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.PenLineCap StrokeDashCap
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeDashCapProperty);
			}
			set
			{
				this.SetValue(StrokeDashCapProperty, value);
			}
		}
		#endif
		// Skipping already declared property StrokeDashArray
		// Skipping already declared property Stroke
		// Skipping already declared property Stretch
		// Skipping already declared property Fill
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Transform GeometryTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member Transform Shape.GeometryTransform is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Transform%20Shape.GeometryTransform");
			}
		}
		#endif
		// Skipping already declared property FillProperty
		// Skipping already declared property StretchProperty
		// Skipping already declared property StrokeDashArrayProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeDashCapProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeDashCap), typeof(global::Microsoft.UI.Xaml.Media.PenLineCap), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.PenLineCap)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeDashOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeDashOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeEndLineCapProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeEndLineCap), typeof(global::Microsoft.UI.Xaml.Media.PenLineCap), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.PenLineCap)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeLineJoinProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeLineJoin), typeof(global::Microsoft.UI.Xaml.Media.PenLineJoin), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.PenLineJoin)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeMiterLimitProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeMiterLimit), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared property StrokeProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeStartLineCapProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeStartLineCap), typeof(global::Microsoft.UI.Xaml.Media.PenLineCap), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.PenLineCap)));
		#endif
		// Skipping already declared property StrokeThicknessProperty
		// Skipping already declared method Microsoft.UI.Xaml.Shapes.Shape.Shape()
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Shape()
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Fill.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Fill.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Stroke.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Stroke.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeMiterLimit.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeMiterLimit.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeThickness.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeThickness.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeStartLineCap.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeStartLineCap.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeEndLineCap.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeEndLineCap.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeLineJoin.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeLineJoin.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashCap.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashCap.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashArray.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashArray.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Stretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.Stretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.GeometryTransform.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionBrush GetAlphaMask()
		{
			throw new global::System.NotImplementedException("The member CompositionBrush Shape.GetAlphaMask() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionBrush%20Shape.GetAlphaMask%28%29");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.FillProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeMiterLimitProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeThicknessProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeStartLineCapProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeEndLineCapProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeLineJoinProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashCapProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StrokeDashArrayProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Shape.StretchProperty.get
	}
}