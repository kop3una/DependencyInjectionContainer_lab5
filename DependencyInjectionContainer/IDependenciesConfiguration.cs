using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionContainer
{
    public interface IDependenciesConfiguration
    {
        IEnumerable<ImplementationContainer> GetImplementations(Type type);

        void Register<TDependency, TImplementation>(bool isSingleton = false, string name = null)
            where TDependency : class
            where TImplementation : TDependency;

        void Register(Type dependency, Type implementation, bool isSingleton = false, string name = null);
    }
}
