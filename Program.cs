using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Создание списка целых чисел и 
    /// основные методы работы с элементами списка 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.Создание пустой коллекии 
            List<int> list = new List<int>();
            //2.Добавление целых значений в коллекцию
            list.Add(1);
            list.Add(10);
            list.Add(25);
            list.Add(17);
            list.Add(10);
            foreach(int elem in list)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            list.Add(30);
            foreach (int elem in list)
            {
                Console.Write($"{elem}\t");
            }
            //3. Вставка элемента по указанному индексу (сдвиг вправо)
            Console.WriteLine();
            list.Insert(0, 500);
            foreach (int elem in list)
            {
                Console.Write($"{elem}\t");
            }
            //4. Добавление в список одномерного массива 
            Console.WriteLine();
            list.AddRange(new[] {-5,0,14});
            foreach (int elem in list)
            {
                Console.Write($"{elem}\t");
            }
            //5. Определение кол-во элементов коллекции
            Console.WriteLine();
            //int size=list.Count;
            //Console.WriteLine($"Текущее кол-во элементов= {size}");
            Console.WriteLine($"Текущее кол-во элементов= {list.Count}");
            //6 Определние индекса элемента со значением 25
            Console.WriteLine();
            Console.WriteLine($"Индекс элемента со значением 25 = {list.IndexOf(25)}");
            //7. Удаление из коллекции первого вхождения элемента со значением 10
            list.Remove(10);
            foreach (int elem in list)
            {
                Console.Write($"{elem}\t");
            }
            //8. Удаление из коллекции элемента с указанным индексом
            Console.WriteLine();
            list.RemoveAt(2); 
            foreach (int elem in list)
            {
                Console.Write($"{elem}\t");
            }

            Console.ReadLine();
        }
    }
}
