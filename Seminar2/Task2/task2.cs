  Console.Clear();
  Console.WriteLine("Введите координату X:");
    double x = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Введите координату Y:");
    double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка находится на одной из координатных осей.");
        }