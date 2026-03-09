using System;
using System.Collections.Generic;

namespace PracticeSynergy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<WORKER> workers = new List<WORKER>();

            Console.WriteLine("=== Ввод данных о сотрудниках ===");
            Console.Write("Сколько сотрудников хотите добавить? ");
            int count = int.Parse(Console.ReadLine());

            // Ввод данных
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nСотрудник №{i + 1}:");

                Console.Write("Фамилия и инициалы: ");
                string name = Console.ReadLine();

                Console.Write("Должность: ");
                string pos = Console.ReadLine();

                Console.Write("Зарплата (руб): ");
                decimal sal = decimal.Parse(Console.ReadLine());

                Console.Write("Год поступления: ");
                int year = int.Parse(Console.ReadLine());

                // Создание объекта через конструктор и добавление в список
                WORKER worker = new WORKER(name, pos, sal, year);
                workers.Add(worker);
            }

            // Поиск по стажу
            Console.Write("\nВведите минимальный стаж для поиска (лет): ");
            int minExperience = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;

            Console.WriteLine($"\nСотрудники со стажем более {minExperience} лет:");
            bool found = false;

            foreach (var worker in workers)
            {
                int exp = worker.CalculateExperience(currentYear);
                if (exp > minExperience)
                {
                    worker.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Таких сотрудников нет.");
            }

            // Ссылка на репозиторий
            Console.WriteLine("\nСсылка на репозиторий GitHub: https://github.com/yourusername/PracticeSynergy"); // Замените на свою ссылку
            Console.ReadKey();
        }
    }
}