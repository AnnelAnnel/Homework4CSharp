using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok4CSharp
{
    public enum color { white, black, blue, red }
    public enum gearboxType { auto, mechanical, robot, variable}

    public partial class Car
    {
        private static double minPrice = 20000; // мин сумма в USD
       
        public static int initialId = 0;    

        private string brand { get; set; }

        private string model { get; set; }

        private color color { get; set; }

        private gearboxType gearboxType { get; set; }

        private double volume { get; set; }

        private int horsePower { get; set; }

        private DateTime productionDate { get; set; }

        private double price { get; set; }

        private int id { get; set; }

        //доступ к приватным полям
        public string brand_
        {
            get
            {
                return this.brand;
            }

            set
            {
                brand = value;
            }
        }
        public string model_
        {
            get
            {
                return this.model;
            }

            set
            {
                model = value;
            }
        }
        public color color_
        {
            get
            {
                return this.color;
            }

            set
            {
                color = value;
            }
        }
        public gearboxType gearboxType_
        {
            get
            {
                return gearboxType;
            }

            set
            {
                gearboxType = value;
            }
        }
        public double volume_
        {
            get
            {
                return volume;
            }

            set
            {
                if(value>0)
                volume = value;
            }
        }
        public int horsePower_
        {
            get
            {
                return horsePower;
            }

            set
            {
                if (value>0)
                horsePower = value;
            }
        }
        public DateTime productionDate_
        {
            get
            {
                return productionDate;
            }

            set
            {
                productionDate = value;
            }
        }
        public double price_
        {
            get
            {
                return price;
            }
            set
            {
                if (value > minPrice)
                    price = value;
                else
                    price = minPrice;
            }
        }
        public int id_
        {
            get
            {
                return id;
            }
           //setter не нужен
        }
        public static double minPrice_
        {
            get
            {
                return minPrice;
            }
            set
            {// мин цену можно только повысить))
                if (value > minPrice)
                    minPrice = value;
            }
        }      
        
        //статический конструктор
        static Car()
        {  //для проверки срабатывания стат конструктора
            Console.WriteLine("Создан первый автомобиль через статический конструктор");           
        }
        //конструкторы
        public Car()
        {
            this.productionDate = DateTime.Now;
            this.price = minPrice;
            this.id = ++initialId;
        }

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            this.productionDate = DateTime.Now;
            this.price = minPrice;
            this.id = ++initialId;
        }

        public Car(string brand, string model, color color, gearboxType gearboxType,
            double volume, int horsePower, DateTime productionDate, double price)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.gearboxType = gearboxType;
            this.volume = volume;
            this.horsePower = horsePower;
            this.productionDate = productionDate;
            this.price = price;
            this.id = ++initialId;
        }
                
        //1 метод
        public void printInfo()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Марка: {0}", brand);
            Console.WriteLine("Модель: {0}", model);
            Console.WriteLine("Цвет: {0}", color);
            Console.WriteLine("Коробка передач: {0}", gearboxType);
            Console.WriteLine("Объем двигателя: {0}", volume);
            Console.WriteLine("Мощность двигателя(л.с.): {0}", horsePower);
            Console.WriteLine("Дата производства: {0}", productionDate);
            Console.WriteLine("Цена: {0}", price);
            Console.WriteLine();
        }
        //2 метод partial
        public void go()
        {
            Console.WriteLine("Автомобиль {0} начал движение", id_);
        }
        //3 метод с передачей аргумента по ссылке
        public double getPowerInKWatts(ref int horsepower)
        {
            return (double)horsepower * 0.735;
        }                  
    }
}
