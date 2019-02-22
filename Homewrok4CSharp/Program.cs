using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok4CSharp
{
    class Program
    {        
        static void Main(string[] args)
        {          
            CarList cars = new CarList();            
            Car car1 = new Car();            
            cars.addCar(car1);
            //задаю значения параметрам 1 авто, проверка доступа к приватным полям
            car1.brand_ = "Hyundai";
            car1.model_ = "Tucson";
            car1.gearboxType_ = gearboxType.robot;

            Car car2 = new Car("Toyota", "Camry 70");
            cars.addCar(car2);
            Car car3 = new Car("Land Rover", "Range Rover");
            cars.addCar(car3);
            Car car4 = new Car("Toyota", "Camry 70", color.white, gearboxType.auto,
                2.5, 210, DateTime.Now, 25000);
            cars.addCar(car4);
            Car car5 = new Car("Hyundai", "Sonata", color.blue, gearboxType.robot,
              2.3, 200, DateTime.Now, 20000);
            cars.addCar(car5);            

            cars.printAll();  
            
            cars.raisePriceRobot();
            Console.WriteLine("Цены после повышения");
            cars.printAll();

            cars.totalSum();
        }
    }
}
