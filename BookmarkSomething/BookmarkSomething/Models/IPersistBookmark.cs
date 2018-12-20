using System.Collections.Generic;

namespace BookmarkSomething.Models
{
    public interface IPersistBookmark
    {
        void Save(string category, string url);

        IEnumerable<string> GetBookmarks(string category);
    }
}