using System;
// Лукьянов глеб  бфзовый уровень 9 лаба
namespace MyApp
{

    public class coin
    {
        public int nominal;
        public int quantity;
        public int total() => nominal * quantity;
        public string ToString() => $"номинал:{nominal}, количество:{quantity}";

        public coin(int nominal, int quantity)
        {
            this.nominal = nominal;
            this.quantity = quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //coin c1 = new coin();
            // c1.nominal = 1;
            // c1.quantity = 5;
            var c1 = new coin(1, 5);



            //coin c2 = new coin();
            //c2.nominal = 2;
            //c2.quantity = 2;
            var c2 = new coin(2, 2);



            //coin c5 = new coin();
            //c5.nominal = 1;
            //c5.quantity = 5;
            var c5 = new coin(1, 5);



            //coin c10 = new coin();
            //c10.nominal = 3;
            //c10.quantity = 10;
            var c10 = new coin(3, 10);


            Console.WriteLine("Данные из c1:");
            Console.WriteLine(c1.ToString());
            Console.WriteLine("Итого: " + c1.total());

            Console.WriteLine("\nДанные из c2:");
            Console.WriteLine(c2.ToString());
            Console.WriteLine("Итого: " + c2.total());

            Console.WriteLine("\nДанные из c5:");
            Console.WriteLine(c5.ToString());
            Console.WriteLine("Итого: " + c5.total());

            Console.WriteLine("\nДанные из c10:");
            Console.WriteLine(c10.ToString());
            Console.WriteLine("Итого: " + c10.total());

        }
    }
}