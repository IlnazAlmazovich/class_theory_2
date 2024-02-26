using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace class_theory
{
    class House
    {
        public int right_wall; //правая стена
        public int left_wall; //левая стена

        public House(int right_wall, int left_wall)//конструктор с параметром
        {
            this.right_wall = right_wall;
            this.left_wall = left_wall;
        }

        public int Square(int right, int left) //метод который вычсчитывает площадь дома
        {
            int a = right * left;
            Console.WriteLine(a);
            return a;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //в скобках указываем парметры, так как у нас создан конструктор данного класса который имеет параметры
            House house = new House(a,b); //создаём экземляр/объект класса
            Console.WriteLine("Площадь дома: ");
            house.Square(a,b); // вызываем метод для рассчёта площади
           
            Console.ReadKey();
        }
    }
}
