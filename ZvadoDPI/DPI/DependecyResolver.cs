using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZvadoDPI.DPI
{
    public class DependecyResolver
    {
        DependencyContainer _container;

        public DependecyResolver(DependencyContainer container)
        {
            _container = container;
        }

        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        private object GetService(Type type)
        {
            Dependency dependency = _container.GetDependency(type);
            ConstructorInfo constructor = dependency.Type.GetConstructors().Single();
            ParameterInfo[] parameters = constructor.GetParameters().ToArray();

            if(parameters.Length > 0)
            {
                object[] parameterImplementation = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    parameterImplementation[i] = GetService(parameters[i].ParameterType);
                }

                return CreateImplementation(dependency, t => Activator.CreateInstance(t, parameterImplementation));
            }
            return CreateImplementation(dependency, t => Activator.CreateInstance(t));
        }

        private object CreateImplementation(Dependency dependency, Func<Type, object> func)
        {
            if (dependency.Implemented)
            {
                return dependency.Implementation;
            }

            object implementation = func(dependency.Type);

            if(dependency.DependencyLifetime == DependencyLifetime.Singleton)
            {
                dependency.AddImplementation(implementation);
            }

            return implementation;
        }
    }
}
