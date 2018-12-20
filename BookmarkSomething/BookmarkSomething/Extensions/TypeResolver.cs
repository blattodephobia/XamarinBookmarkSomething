using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace BookmarkSomething
{
    [ContentProperty(nameof(Type))]
    public class TypeResolver : IMarkupExtension
    {
        public Type Type { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService(Type);
        }
    }
}
