using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZvadoDPI.DPI
{
    public class DependencyContainer
    {
        List<Dependency> _dependecies;

        public DependencyContainer()
        {
            _dependecies = new();
        }

        public void AddSingleton<T>()
        {
            _dependecies.Add(new Dependency(typeof(T), DependencyLifetime.Singleton));
        }

        public void AddTransient<T>()
        {
            _dependecies.Add(new Dependency(typeof(T), DependencyLifetime.Transient));
        }

        public Dependency GetDependency(Type type)
        {
            return _dependecies.First(d => d.Type.Name == type.Name);
        }
    }
}
