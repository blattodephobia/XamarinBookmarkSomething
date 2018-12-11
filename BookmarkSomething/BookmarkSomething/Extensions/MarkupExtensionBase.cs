using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;

namespace BookmarkSomething.Extensions
{
    public class MarkupExtensionBase<T> : IMarkupExtension, IMarkupExtension<T>
    {
        public virtual T ProvideValue(IServiceProvider serviceProvider)
        {
            return default(T);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
