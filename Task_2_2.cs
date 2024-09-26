using System;

class Program
{
  static void Main()
  {
    // Инициализируем массивы для имени, возраста и города (3 пользователя)
    string[] names = new string[3];
    int[] ages = new int[3];
    string[] cities = new string[3];

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

    // Запрос порядкового номера для вывода информации
    Console.Write("Введите порядковый номер пользователя (1-3), данные которого хотите вывести: ");
    int userIndex;

    if (int.TryParse(Console.ReadLine(), out userIndex) && userIndex >= 1 && userIndex <= 3)
    {
      int index = userIndex - 1; // Приводим к индексу массива
      Console.WriteLine($"Имя: {names[index]}, Возраст: {ages[index]}, Город: {cities[index]}");
    }
    else
    {
      Console.WriteLine("Некорректный номер пользователя.");
    }
  }
}
