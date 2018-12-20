using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BookmarkSomething
{
    public partial class Chart : ContentView
    {
        public static readonly BindableProperty XAxisMinimumProperty = BindableProperty.Create(
            propertyName: nameof(XAxisMinimum), returnType:typeof(int), declaringType: typeof(Chart));

        public static readonly BindableProperty XAxisMaximumProperty = BindableProperty.Create(
            propertyName: nameof(XAxisMaximum), returnType: typeof(int), declaringType: typeof(Chart));

        public static readonly BindableProperty YAxisMinimumProperty = BindableProperty.Create(
            propertyName: nameof(YAxisMinimum), returnType: typeof(int), declaringType: typeof(Chart));

        public static readonly BindableProperty YAxisMaximumProperty = BindableProperty.Create(
            propertyName: nameof(YAxisMaximum), returnType: typeof(int), declaringType: typeof(Chart));

        public int XAxisMinimum
        {
            get => (int)GetValue(XAxisMinimumProperty);

            set => SetValue(XAxisMinimumProperty, value);
        }

        public int XAxisMaximum
        {
            get => (int)GetValue(XAxisMaximumProperty);

            set => SetValue(XAxisMaximumProperty, value);
        }

        public int YAxisMinimum
        {
            get => (int)GetValue(YAxisMinimumProperty);

            set => SetValue(YAxisMinimumProperty, value);
        }

        public int YAxisMaximum
        {
            get => (int)GetValue(YAxisMaximumProperty);

            set => SetValue(YAxisMaximumProperty, value);
        }

        public Chart()
        {
            
        }
    }
}
