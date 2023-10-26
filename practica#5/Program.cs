using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Вызываем метод GenerateException, который генерирует исключение
                HandleException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        static void HandleException()
        {
            try
            {
                // Генерируем исключение в этом методе
                throw new ApplicationException("Произошла ошибка в HandleException методе.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Обработка ошибки в HandleException методе: " + ex.Message);
                // Поднимаем исключение в вызывающий метод
                throw;
            }
        }
    }
}
