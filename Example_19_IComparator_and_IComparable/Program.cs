using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_19_IComparator_and_IComparable
{
    class Program
    {
        class AutoShop
        {
            public string CarName { set; get; }
            public int MaxSpeed { get; set; }
            public double Cost { get; set; }
            public byte Discount { get; set; }
            public int ID { get; set; }

            public AutoShop() { }
            public AutoShop(string CarName, int MaxSpeed, double Cost, byte Discount, int ID)
            {
                this.CarName = CarName;
                this.MaxSpeed = MaxSpeed;
                this.Cost = Cost;
                this.Discount = Discount;
                this.ID = ID;
            }

            public override string ToString()
            {
                return String.Format("{4}\tМарка: {0}\tМакс. скорость: {1}\tЦена: {2:C}\tСкидка: {3}%",
                    this.CarName, this.MaxSpeed, this.Cost, this.Discount, this.ID);
            }
        }

        class PriceComp<T> : IComparer<T>
            where T : AutoShop
        {
            // Реализуем интерфейс IComparer<T>
            public int Compare(T x, T y)
            {
                if (x.Cost < y.Cost)
                    return -1;
                if (x.Cost > y.Cost)
                    return 1;
                else return 0;
            }
        }

        class DiscountComp<T> : IComparer<T>
            where T : AutoShop
        {
            // Реализуем интерфейс IComparer<T>
            public int Compare(T x, T y)
            {
                if (x.Discount < y.Discount)
                    return 1;
                if (x.Discount > y.Discount)
                    return -1;
                else return 0;
            }
        }

        static void Main(string[] args)
        {
            PriceComp<AutoShop> priceSort = new PriceComp<AutoShop>();
            DiscountComp<AutoShop> discountSort = new DiscountComp<AutoShop>();
            List<AutoShop> dic = new List<AutoShop>();


            dic.Add(new AutoShop("Toyota Corolla", 180, 300000, 5, 1));
            dic.Add(new AutoShop("VAZ 2114i", 160, 220000, 0, 2));
            dic.Add(new AutoShop("Daewoo Nexia", 140, 260000, 5, 3));
            dic.Add(new AutoShop("Honda Torneo", 220, 400000, 7, 4));
            dic.Add(new AutoShop("Audi R8 Best", 360, 4200000, 3, 5));

            Console.WriteLine("Исходный каталог автомобилей: \n");
            Console.WindowWidth = 100;
            foreach (AutoShop a in dic)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nТеперь автомобили отсортированны по стоимости: \n");
            dic.Sort(priceSort);
            foreach (AutoShop a in dic)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nТеперь автомобили отсортированны по скидке: \n");
            dic.Sort(discountSort);
            foreach (AutoShop a in dic)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nТеперь автомобили отсортированны по скорости: \n");
            dic.Sort((x,y) => {
                if (x.MaxSpeed > y.MaxSpeed)
                {
                    return -1;
                }
                else if (x.MaxSpeed < y.MaxSpeed)
                {
                    return 1;
                }
                else return 0;
            });
            foreach (AutoShop a in dic)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
