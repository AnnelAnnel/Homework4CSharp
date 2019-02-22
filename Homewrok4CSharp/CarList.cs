using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok4CSharp
{
    public class CarList
    {
        List<Car> cars = new List<Car>();
        //добавляю авто
        public void addCar(Car car)
        {
            cars.Add(car);
        }
       //считаю стоимость всех авто в листе
        public void totalSum()
        {
            double sum = 0;
            for (int i = 0; i < cars.Count; i++)
            {
               sum+= cars[i].price_;
            }
            Console.WriteLine("Общая стоимость автомобилей в блоке {0}", sum);
            Console.WriteLine();
        }
        //печатаю все авто в листе
        public void printAll()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].printInfo();
            }
        }
        //поднимаю цену авто с коробкой передач роботы
        public void raisePriceRobot()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].gearboxType_ == gearboxType.robot)
                    cars[i].price_ += 3000;
            }
        }       
    }
}
