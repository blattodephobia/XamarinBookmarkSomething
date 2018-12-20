using System;
using Autofac;
using BookmarkSomething.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace BookmarkSomething
{
    public partial class App : Application
    {
        private static IContainer _container;
        private static readonly ContainerBuilder Builder = new ContainerBuilder();
        
        public App(TypeRegistration registration)
        {
            DependencyResolver.ResolveUsing(registration.GetResolver());
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
