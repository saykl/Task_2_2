using System;

class Program
{
  static void Main()
  {
    // Инициализируем массивы для имени, возраста и города (3 пользователя)
    string[] names = new string[3];
    int[] ages = new int[3];
    string[] cities = new string[3];

    // Массивы для хранения вопросов и типов данных
    string[] prompts = { "Имя", "Возраст", "Город" };
    Action<int>[] inputActions = {
            index => names[index] = Console.ReadLine(),
            index => ages[index] = int.Parse(Console.ReadLine()),
            index => cities[index] = Console.ReadLine()
        };

    // Ввод данных для 3 пользователей
    for (int userCount = 0; userCount < 3; userCount++)
    {
      Console.WriteLine($"Введите данные пользователя {userCount + 1}:");

      for (int i = 0; i < prompts.Length; i++)
      {
        Console.Write($"{prompts[i]}: ");
        inputActions[i](userCount);
      }
    }

    // Запрос имени для вывода информации
    Console.Write("Введите имя пользователя, данные которого хотите вывести: ");
    string searchName = Console.ReadLine();

    // Поиск и вывод данных
    bool userFound = false;
    for (int i = 0; i < 3; i++)
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
