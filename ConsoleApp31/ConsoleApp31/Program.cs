using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l4t34

{

    /*

    * Внутри класса Program создайте и реализуйте публичный метод GetMoreInformation(), который:

    * 1) Принимает 1 целочисленный параметр.

    * 2) Выводит в консоль информацию о полученном числе в следующем формате:

    * "Число ХХХ отрицательное\положительное! Число состоит из N цифр!",

    * где ХХХ - значение полученного параметра, N - количество цифр в полученном числе.

    * 3) Если введённое число ноль - метод ничего не должен выводить в консоль.

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            GetMoreInformation(int.Parse(Console.ReadLine()));

        }
        public static void GetMoreInformation(int a)
        {
            if (a!=0)
            {
                if (a>0)
                {
                    Console.Write("Число " + a + " положительное! ");
                }
                else
                {
                    Console.Write("Число" + a + " отрицательоне! ");
                }
                int ten = 10;
                int kol = 1;
                while (Math.Abs(a / ten) > 0)
                {
                    kol++;
                    ten *= 10;
                }
                Console.WriteLine("Число состоит из " + kol + " цифр");
            }
            else
            {
                Console.WriteLine("Ничего");
            }
        }
    }

}