using System;

class Program
{
    static void Main()
    {
        // Инициализируем отдельные массивы для имени, возраста и города
        string[] names = new string[5];
        int[] ages = new int[5];
        string[] cities = new string[5];
        int userCount = 0;

        // Ввод данных о пользователях
        while (userCount < 5)
        {
            Console.WriteLine($"Введите данные пользователя {userCount + 1}:");

            Console.Write("Имя: ");
            names[userCount] = Console.ReadLine();

            Console.Write("Возраст: ");
            ages[userCount] = int.Parse(Console.ReadLine());

            Console.Write("Город: ");
            cities[userCount] = Console.ReadLine();

            userCount++;

            Console.WriteLine("Хотите ввести ещё одного пользователя? (y/n)");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "y")
            {
                break;
            }
        }

        // Запрос имени для вывода информации
        Console.Write("Введите имя пользователя, данные которого хотите вывести: ");
        string searchName = Console.ReadLine();

        // Поиск и вывод данных
        bool userFound = false;
        for (int i = 0; i < userCount; i++)
        {
            if (names[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Имя: {names[i]}, Возраст: {ages[i]}, Город: {cities[i]}");
                userFound = true;
                break;
            }
        }

        if (!userFound)
        {
            Console.WriteLine("Пользователь не найден.");
        }
    }
}
