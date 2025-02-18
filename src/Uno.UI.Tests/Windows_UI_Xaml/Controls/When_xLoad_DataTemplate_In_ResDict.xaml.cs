﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Tests.Windows_UI_Xaml.Controls
{
	public sealed partial class When_xLoad_DataTemplate_In_ResDict : UserControl
	{
		public When_xLoad_DataTemplate_In_ResDict()
		{
			this.InitializeComponent();
		}

		public bool MyVisibility
		{
			get { return (bool)GetValue(MyVisibilityProperty); }
			set { SetValue(MyVisibilityProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MyVisibility.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MyVisibilityProperty =
			DependencyProperty.Register("MyVisibility", typeof(bool), typeof(When_xLoad_DataTemplate_In_ResDict), new PropertyMetadata(false));
	}

	public class When_xLoad_DataTemplate_In_ResDict_Model : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		private bool visible;

		public bool Visible
		{
			get { return visible; }
			set
			{
				visible = value;
				PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Visible)));
			}
		}

	}
}
