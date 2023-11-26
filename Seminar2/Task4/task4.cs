Console.Clear();
 {
        Console.WriteLine("Введите натуральное число N:");
        int n = Convert.ToInt32(Console.ReadLine());

        string digits = string.Join(", ", n.ToString().ToCharArray());
        Console.WriteLine("Цифры введенного числа: " + digits);
    }