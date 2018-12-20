using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace BookmarkSomething.Droid
{
    public class ChartRenderer : ViewRenderer<BookmarkSomething.Chart, Chart>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BookmarkSomething.Chart> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new Chart(Context));
            }
        }

        public ChartRenderer(Context context) : base(context)
        {
        }
    }
}