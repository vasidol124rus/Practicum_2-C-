Console.Clear();
Console.Write("Введите любое натуральное число: ");
int number = int.Parse(Console.ReadLine()!);
for (int i = 0; i <= number; i++)
    Console.Write($"{i},");