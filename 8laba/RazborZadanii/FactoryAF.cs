using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RazborZadanii
{
    class FactoryAF
    {
        public List<Customer> customers { get; set; } = new List<Customer>();
        private List<Car> cars { get; set; } = new List<Car>();
        public void AddCar(int pedalSize)
        {
            cars.Add(new Car(pedalSize) { Number = cars.Count + 1 });   
            
        }

        public void SaleCar()
        {
            foreach(Customer customer in customers)
            {
                if (customer.Car is null)
                {
                    if (cars.Any() == true)
                    {
                        customer.Car = cars[0];
                        cars.Remove(cars[0]);
                    }

                }
            }
            if (cars.Any() == true)
            {
                cars.Clear();
            } 
        }
    }
}
