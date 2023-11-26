Console.Clear();
Console.WriteLine("Введите число для проверки:");
        int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
        Console.WriteLine("Число кратно 7 и 23 одновременно.");
else
        Console.WriteLine("Число не кратно 7 и 23 одновременно.");