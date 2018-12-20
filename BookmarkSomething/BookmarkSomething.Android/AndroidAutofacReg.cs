﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using BookmarkSomething.Droid.Models;
using BookmarkSomething.Models;

namespace BookmarkSomething.Droid
{
    public class AndroidAutofacReg : AutofacTypeReg
    {
        public override void RegisterBookmarkPersistence()
        {
            Builder.RegisterType<AndroidPersistService>().As<IPersistBookmark>();
        }
    }
}