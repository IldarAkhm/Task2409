using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace DZ
{
    internal class Program
    {
        enum daysofweek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
           
                
        
        static void Main(string[] args)
        {
            //Console.Write("Задание 1. Вася с большой головой\nВведите размеры форточки(сначала ширину): ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите высоту форточки: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Теперь введите диаметр головы Васи: ");
            //int diameter = Convert.ToInt32(Console.ReadLine());
            //double hypotenuse = Math.Sqrt(Math.Pow(weight, 2) + Math.Pow(height, 2));
            //var ln = 2;
            //if (hypotenuse - diameter > ln)
            //{
            //    Console.WriteLine("Вася просунул свою большую голову в эту форточку");
            //    Console.ReadKey();
            //}
            //else { Console.Write("Вася с толстой головой"); Console.ReadKey(); }

            //Console.Write("Задание 2. Таблица умножения\n Введите число n: ");
            //double num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(MyLib.Mult.MultB(num));
            //Console.WriteLine(MyLib.Mult.MultD(num));
            //Console.ReadKey();

            //Console.Write("Задание 3. БэнгБумБэнгБум\nВведите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool testdivision3 = Convert.ToBoolean(number % 3 == 0);
            //bool testdivision5 = Convert.ToBoolean(number % 5 == 0);
            //bool testdivision35 = Convert.ToBoolean(number % 3 == 0 && number % 5 == 0);
            //if (testdivision3 && testdivision35 == false)
            //{
            //    Console.WriteLine("Bang");
            //}
            //else if (testdivision5 && testdivision35 == false)
            //{
            //    Console.WriteLine("Boom");
            //}
            //else if (testdivision35)
            //{
            //    Console.WriteLine("BangBoom");
            //}    
            //else
            //{
            //    Console.WriteLine("Past");
            //}
            //Console.ReadLine();

            //Console.Write("Задание 4. Проверка на заглавные буквы\n Введите строку: ");
            //string line = Console.ReadLine();
            //if (line.ToUpper() == line)
            //{
            //    Console.WriteLine("Все буквы заглавными буквами");
            //}
            //else
            //{
            //    Console.WriteLine("нет");
            //}
            //Console.ReadLine();

            //Console.Write("Задание 5. Овцы\nВведите целое число:");
            //try
            //{
            //    uint cnt = Convert.ToUInt32(Console.ReadLine());
            //    for (int cnti = 1; cnti != cnt; cnti++)
            //    {
            //        Console.WriteLine($"{cnti} овца");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Вы ввели отрицательное число");
            //}
            //Console.ReadLine();


            //Console.Write("Задание 6. Среднее Арифметическое");

            //try
            //{
            //    Console.Write("Введи количество символов:");
            //    int cntnum = int.Parse(Console.ReadLine());
            //    List<int> listint = new List<int>();
            //    int i = 0;
            //    while (i != cntnum)
            //    {
            //        Console.WriteLine("Введи число: ");
            //        int number = int.Parse(Console.ReadLine());
            //        listint.Add(number);
            //        i++;
            //    }
            //    int cnt = 0;
            //    double summ = 0;
            //    while (listint[cnt] >= 0)
            //    {
            //        summ += (double)listint[cnt];
            //        cnt++;
            //    }
            //    double average = (summ / ((double)(cnt)));
            //    Console.WriteLine(average);

            //}
            //catch 
            //{
            //    Console.WriteLine("Ты сделал что-то не так");
            //}
            //finally
            //{
            //    Console.WriteLine("Попробуй еще раз," +
            //        "в конце должно быть отрицательное число");
            //}
            //Console.ReadLine();

            //Console.Write("Задание 7. Игральные карты");
            //try
            //{
            //    Console.Write("Введите число k (6 <= k <= 14): ");
            //    int numcard = int.Parse(Console.ReadLine());
            //    if (6 <= numcard && numcard <= 14)
            //    {
            //        Console.WriteLine(MyLib.Mult.card(numcard));
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("Ты сделал что-то не так");
            //}
            //finally
            //{
            //    Console.WriteLine("Попробуй еще раз");
            //}
            //Console.ReadLine();

            //Console.Write("Задание 8. Массив строк\nВведите количество" +
            //    "индексов в массиве: ");
            //int cntind = int.Parse(Console.ReadLine());
            //List<string> barbielist = new List<string>();
            //int cnti = 0;
            //string barbiedoll = "Barbie Doll";
            //string hellokitty = "Hello Kitty";
            //while (cnti != cntind)
            //{
            //    Console.WriteLine("Введи элемент массива: ");
            //    barbielist.Add(Console.ReadLine());
            //    cnti++;
            //}
            //int cntbarbie = 0;
            //foreach (string barbie in barbielist)
            //{
            //    if (barbie == barbiedoll)
            //    {
            //        cntbarbie++;
            //    }
            //    else if (barbie == hellokitty)
            //    {
            //        cntbarbie++;
            //    }
            //}
            //Console.WriteLine($"В сумке {cntbarbie} кукол");
            //Console.ReadLine();

            //Console.Write("Задание 9. Дни недели\nВведите число n(1 <= n <= 7): ");
            //int day = int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine(daysofweek.Monday);
            //        break;
            //    case 2:
            //        Console.WriteLine(daysofweek.Tuesday);
            //        break;
            //    case 3:
            //        Console.WriteLine(daysofweek.Wednesday);
            //        break;
            //    case 4:
            //        Console.WriteLine(daysofweek.Thursday);
            //        break;
            //    case 5:
            //        Console.WriteLine(daysofweek.Friday);
            //        break;
            //    case 6:
            //        Console.WriteLine(daysofweek.Saturday);
            //        break;
            //    case 7:
            //        Console.WriteLine(daysofweek.Sunday);
            //        break;
            //    default:
            //        Console.WriteLine("Такого нет");
            //        break;
            //}
            //Console.ReadLine();

            //Console.WriteLine("Задание 10. Сортировка массива");
            //List<int> ints = new List<int>();
            //Console.WriteLine("Введите количество символов в списке: ");
            //int cntlist = int.Parse(Console.ReadLine());
            //int cnt = 0;
            //while (cnt != cntlist)
            //{
            //    Console.WriteLine("Введи число: ");
            //    int write = int.Parse(Console.ReadLine());
            //    ints.Add(write);
            //    cnt++;
            //}
            ////int temp;
            ////for (int i = 0; i < ints.Count; i++) 
            ////{
            ////    for (int j = 0; j < ints.Count-1-i; j++)
            ////    {
            ////        if (ints[j] > ints[j + 1])
            ////        {
            ////            temp = ints[j];
            ////            ints[j] = ints[j + 1];
            ////            ints[j + 1] = temp;
            ////        }    
            ////    }
            ////}

            ////for (int i = 0; i < ints.Count; i++)
            ////{
            ////    Console.WriteLine(ints[i]);
            ////}
            ////Console.ReadLine();

            //ints.Sort();
            //foreach (int n in ints)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();

            Console.Write("Задание 11. Последовательность\n" +
                "Введите количество элементов в массиве: ");
            int elements = int.Parse(Console.ReadLine());
            int cnt = 0;
            List<int> ints = new List<int>();
            while (cnt != elements)
            {
                Console.WriteLine("Введите число: ");
                int num = int.Parse(Console.ReadLine());
                ints.Add(num);
                cnt++;
            }
            
            for (int i = 0; i < ints.Count; i++)
            {
                for (int j = i+1; j < ints.Count; j ++)
                {
                    if (ints[i] > ints[j])
                    {
                        Console.WriteLine($"Элемент с индексом" +
                            $"{i} больше элемента с индексом {j}");
                    }
                }
            }
            Console.ReadLine();
        }   

    }
}
