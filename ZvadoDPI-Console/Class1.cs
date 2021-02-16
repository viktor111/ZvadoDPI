using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZvadoDPI.DPI;

namespace ZvadoDPI_Console
{
    public class Class1
    {
        private DependecyResolver _resolver;

        public Class1(DependecyResolver resolver)
        {
            _resolver = resolver;
        }

        public void Test()
        {
            var a =_resolver.GetService<SqlAdminService>();
            a.CreateProduct();
        }
    }
}
