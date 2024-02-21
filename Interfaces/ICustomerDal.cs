using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQLServer added");
        }

        public void Delete()
        {
            Console.WriteLine("SQLServer deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQLServer updated");
        }
    }
    public class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    public class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");

        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");

        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    public class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}