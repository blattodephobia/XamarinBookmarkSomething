using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookmarkSomething.Models
{
    class PersistBookmarkFileSystem : IPersistBookmark
    {
        public void Save(string category, string url)
        {
            File.AppendAllLines(category, new [] { url });
        }

        public IEnumerable<string> GetBookmarks(string category)
        {
            return File.ReadAllLines(category);
        }
    }
}
