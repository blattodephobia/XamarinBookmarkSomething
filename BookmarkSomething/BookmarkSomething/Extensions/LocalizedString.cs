using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;

namespace BookmarkSomething.Extensions
{
    public class LocalizedString : IMarkupExtension<string>
    {
        public string ProvideValue(IServiceProvider serviceProvider)
        {
            return "Hello world!";
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
