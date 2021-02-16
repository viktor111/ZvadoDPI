using System;
using System.Collections.Generic;
using System.Text;

namespace ZvadoDPI.DPI
{
    public class Dependency
    {
        public Dependency(Type type, DependencyLifetime dependecyLifetime)
        {
            Type = type;
            DependencyLifetime = DependencyLifetime;
        }

        public Type Type { get; set; }

        public DependencyLifetime DependencyLifetime { get; set; }

        public object Implementation { get; set; }

        public bool Implemented { get; set; }

        public void AddImplementation(object implementation)
        {
            Implementation = implementation;
            Implemented = true;
        }
    }
}
