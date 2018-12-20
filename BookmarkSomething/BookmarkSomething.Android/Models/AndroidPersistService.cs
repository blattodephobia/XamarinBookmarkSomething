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
using BookmarkSomething.Models;
using Xamarin.Forms;
using Application = Xamarin.Forms.Application;

namespace BookmarkSomething.Droid.Models
{
    public class AndroidPersistService : IPersistBookmark
    {
        private readonly Application _application;

        public AndroidPersistService()
        {
            _application = Application.Current;
        }

        public void Save(string category, string url)
        {
            if (!_application.Properties.ContainsKey(category))
            {
                _application.Properties.Add(category, null);
            }

            _application.Properties[category] = url;
        }

        public IEnumerable<string> GetBookmarks(string category)
        {
            return _application.Properties.ContainsKey(category)
                ? new [] { _application.Properties[category] as string }
                : Enumerable.Empty<string>();
        }
    }
}