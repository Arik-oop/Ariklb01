using Ariklb01;
using System;

namespace Ariklb01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаём двух персон
                var person1 = new Person("Алексей", "Иванов", 25, Gender.Male);
                var person2 = new Person("Мария", "Петрова", 30, Gender.Female);

                // Выводим на экран
                Console.WriteLine(person1);
                Console.WriteLine(person2);

                // Попытка создать персону с отрицательным возрастом (должна вызвать исключение)
                var person3 = new Person("Тест", "Ошибка", -5, Gender.Male);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}