using System;
using System.Collections.Generic;
using System.Text;

namespace BookmarkSomething
{
    public abstract class TypeRegistration
    {
        public abstract void RegisterBookmarkPersistence();

        public abstract Func<Type, object> GetResolver();
    }
}
