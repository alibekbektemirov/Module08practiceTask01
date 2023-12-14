using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08practiceTask01
{



    class Program
    {
        static void Main()
        {
            Console.Write("Введите начальный индекс: ");
            int lower = int.Parse(Console.ReadLine());
            Console.Write("Введите конечный индекс: ");
            int upper = int.Parse(Console.ReadLine());

            RangeOfArray arr = new RangeOfArray(lower, upper);

            // Заполняем массив
            for (int i = lower; i <= upper; i++)
            {
                arr[i] = i * 10;
            }

            // Чтение значений из массива
            for (int i = lower; i <= upper; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            // Пример обработки исключения при попытке доступа за пределы диапазона
            try
            {
                arr[upper + 1] = 110; // Вызовет исключение
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

