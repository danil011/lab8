using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazborZadanii
{


    class Program
    {
        static void Main(string[] args)
        {

            FactoryAF factory = new FactoryAF();
            factory.customers.Add(new Customer { FIO = "Иванов Иван Иванович" });
            factory.customers.Add(new Customer { FIO = "Петров Петр Петрович" });
            factory.customers.Add(new Customer { FIO = "Дмитриев Дмитрий Дмитриевич" });

            foreach (Customer customer in factory.customers)
            {
                Console.WriteLine(customer.FIO);
                if (customer.Car is null)
                {
                    Console.WriteLine("Ошибка");

                }
                else
                {
                    Console.WriteLine(customer.Car.Engine.Size);
                }
            }


            factory.AddCar(12);
            factory.AddCar(20);
            factory.SaleCar();

            foreach (Customer customer in factory.customers)
            {
                Console.WriteLine(customer.FIO);
                if (customer.Car is null)
                {
                    Console.WriteLine("Ошибка");

                }
                else
                {
                    Console.WriteLine(customer.Car.Engine.Size);
                }

            }
        }
    }
}
