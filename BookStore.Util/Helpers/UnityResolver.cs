using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace BookStore.Util.Helpers
{
    public class UnityResolver : IDependencyResolver
    {
        protected IUnityContainer container;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;

        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
