using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using BookmarkSomething.Models;

namespace BookmarkSomething
{
    public class AutofacTypeReg : TypeRegistration
    {
        protected ContainerBuilder Builder { get; private set; }

        private IContainer _container;
        private IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    RegisterBookmarkPersistence();
                    _container = Builder.Build();
                }

                return _container;
            }
        }

        public AutofacTypeReg()
        {
            Builder = new ContainerBuilder();
        }

        public override void RegisterBookmarkPersistence()
        {
            Builder.RegisterType<PersistBookmarkFileSystem>().As<IPersistBookmark>();
        }

        public override Func<Type, object> GetResolver()
        {
            return type => Container.IsRegistered(type) ? Container.Resolve(type) : null;
        }
    }
}
