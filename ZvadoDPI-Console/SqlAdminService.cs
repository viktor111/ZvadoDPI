using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvadoDPI_Console
{
    public class SqlAdminService
    {
        int _num;

        public SqlAdminService()
        {
            _num = new Random().Next();
        }

        public void CreateProduct()
        {
            Console.WriteLine(_num + " created");
        }

        public void DeleteUser(string username)
        {
            Console.WriteLine("Deleted user: " + username);
        }
    }
}
