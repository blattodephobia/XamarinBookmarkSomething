using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Windows.Input;
using BookmarkSomething.Models;
using Xamarin.Forms;

namespace BookmarkSomething.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private readonly IPersistBookmark _persistBookmark;

        public ICommand LikeCommand { get; }

        public ObservableCollection<string> Names { get; } = new ObservableCollection<string>() { "Anna", "Beloslava", "Veneta" };

        public MainViewModel() :
            this(DependencyService.Resolve<IPersistBookmark>())
        {
        }

        public MainViewModel(IPersistBookmark persistBookmark)
        {
            _persistBookmark = persistBookmark;
            LikeCommand = new Command((x) => { _persistBookmark.Save("matches", x?.ToString()); });
        }
    }
}
