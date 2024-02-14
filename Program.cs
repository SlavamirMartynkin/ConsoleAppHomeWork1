namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[2], out int num2))
                {
                    if (args[1] == "+")
                    {
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    }
                    if (args[1] == "-")
                    {
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    }
                    if (args[1] == "*")
                    {
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    }
                    if (args[1] == "/")
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    else Console.WriteLine("Наш калькулятор не знает такого действия");
                }
            }
            else Console.WriteLine("Корректно введите пример!");
        }
    }
    }
}
