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
                // a. Создаём два списка по три человека
                var list1 = new PersonList();
                var list2 = new PersonList();

                list1.Add(new Person("Алексей", "Иванов", 25, Gender.Male));
                list1.Add(new Person("Мария", "Петрова", 30, Gender.Female));
                list1.Add(new Person("Сергей", "Сидоров", 40, Gender.Male));

                list2.Add(new Person("Анна", "Кузнецова", 22, Gender.Female));
                list2.Add(new Person("Дмитрий", "Морозов", 35, Gender.Male));
                list2.Add(new Person("Елена", "Волкова", 28, Gender.Female));

                // b. Вывод содержимого списков
                Console.WriteLine("=== Список 1 ===");
                PrintList(list1);
                Console.WriteLine("\n=== Список 2 ===");
                PrintList(list2);
                Pause();

                // c. Добавляем нового человека в первый список
                list1.Add(new Person("Ольга", "Новикова", 33, Gender.Female));
                Console.WriteLine("\n→ Добавлен человек в Список 1");
                PrintList(list1);
                Pause();

                // d. Копируем второго человека из list1 в list2
                var personToCopy = list1.Get(1); // Мария Петрова
                list2.Add(personToCopy);
                Console.WriteLine("\n→ Скопирован второй человек из Списка 1 в Список 2");
                Console.WriteLine("Список 2 теперь содержит:");
                PrintList(list2);
                Pause();

                // e. Удаляем второго человека из первого списка
                list1.RemoveAt(1);
                Console.WriteLine("\n→ Удалён второй человек из Списка 1");
                Console.WriteLine("Список 1:");
                PrintList(list1);
                Console.WriteLine("\nСписок 2 (проверка: Мария осталась):");
                PrintList(list2);
                Pause();

                // f. Очищаем второй список
                list2.Clear();
                Console.WriteLine("\n→ Список 2 очищен");
                Console.WriteLine($"Список 2 содержит {list2.Count} элементов.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        /// <summary>
        /// Вспомогательный метод для вывода всех элементов списка.
        /// </summary>
        static void PrintList(PersonList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}: {list.Get(i)}");
            }
        }

        /// <summary>
        /// Ожидание нажатия клавиши.
        /// </summary>
        static void Pause()
        {
            Console.WriteLine("\n(Нажмите любую клавишу для продолжения...)");
            Console.ReadKey();
        }
    }
}