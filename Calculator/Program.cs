using System;

class Calculator
{
    private static double memory = 0;
    static double current = 0;

    private void CalcApp()
    {
        Console.Write("Введите начальное значение: ");
        current = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Текущее значение: {current}");

        while (true)
        {
            Console.Write("Необходимо выбрать операцию (+, -, *, /, %, 1/, ^2, sqrt, m+, m-, mr, clear, exit): ");
            string operation = Console.ReadLine().ToLower();

            //warn! : div by zero in case "1/"  -> equals inf, sqrt with negative digits will not work -> equals NaN
            switch (operation)
            {
                case "1/":
                case "^2":
                case "sqrt":
                    if (operation == "^2") current = Math.Pow(current, 2);
                    if (operation == "sqrt") current = Math.Sqrt(current);
                    if (operation == "1/") current = 1 / current;

                    Console.WriteLine($"Текущее значение: {current}");
                    break;

                case "mr":
                case "m-":
                case "m+":

                    if (operation == "m-") memory -= current;
                    if (operation == "m+") memory += current;

                    Console.WriteLine($"Значение в памяти: {memory}");

                    if (operation == "mr") current = memory; Console.WriteLine($"Значение из памяти перенесено успешно!\n{current} - текущее значение");

                    break;

                //warn! : div by zero in case "/"  -> equals inf
                case "+":
                case "-":
                case "*":
                case "/":

                    Console.WriteLine("Введите второе значение: ");
                    double extraNum = Convert.ToDouble(Console.ReadLine());

                    if (operation == "+") current += extraNum;
                    if (operation == "-") current -= extraNum;
                    if (operation == "*") current *= extraNum;
                    if (operation == "/") current /= extraNum;

                    Console.WriteLine($"Текущее значение: {current}");
                    break;

                case "%":
                    Console.WriteLine("Введите процент: ");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    current /= 100;
                    current *= percent;

                    Console.WriteLine($"Текущее значение: {current}");
                    break;

                case "clear":
                    current = 0;

                    Console.WriteLine($"Обнуление прошло успешно! Текущее значение - {current}");
                    break;

                case "exit":
                    return;

                // warn! : no default for unknown operations
            }
        }


    }

     static void Main()
    {
        Calculator calcApp = new Calculator();
        calcApp.CalcApp();
    }
}
