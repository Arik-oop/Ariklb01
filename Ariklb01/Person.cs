using Ariklb01;
using System;

namespace Ariklb01
{
    /// <summary>
    /// Имя, фамилию, возраст и пол человека.
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <exception cref="ArgumentException">Возраст отрицательный.</exception>
        public Person(string name, string surname, int age, Gender gender)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным.", nameof(age));

            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Переопределение метода ToString.
        /// </summary>
        /// <returns>Строковое представление.</returns>
        public override string ToString()
        {
            return $"{Name} {Surname}, {Age} лет, пол: {Gender}";
        }
    }
}
