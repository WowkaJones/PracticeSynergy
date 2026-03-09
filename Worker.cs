using System;

namespace PracticeSynergy
{
    /// <summary>
    /// Класс, описывающий сотрудника организации
    /// </summary>
    public class WORKER
    {
        // Закрытые поля (инкапсуляция)
        private string _fullName;
        private string _position;
        private decimal _salary;
        private int _startYear;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public WORKER()
        {
            _fullName = "Не указано";
            _position = "Не указана";
            _salary = 0;
            _startYear = DateTime.Now.Year;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public WORKER(string fullName, string position, decimal salary, int startYear)
        {
            _fullName = fullName;
            _position = position;
            _salary = salary;
            _startYear = startYear;
        }

        // Свойства для доступа к полям
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        /// <summary>
        /// Метод для расчета стажа работы
        /// </summary>
        /// <param name="currentYear">Текущий год</param>
        /// <returns>Стаж в годах</returns>
        public int CalculateExperience(int currentYear)
        {
            return currentYear - _startYear;
        }

        /// <summary>
        /// Метод для вывода информации о сотруднике
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"ФИО: {_fullName}");
            Console.WriteLine($"Должность: {_position}");
            Console.WriteLine($"Зарплата: {_salary:C2}");
            Console.WriteLine($"Год поступления: {_startYear}");
            Console.WriteLine("-------------------------");
        }
    }
}