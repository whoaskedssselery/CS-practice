 using System;

class BankAcc
{
    static void Main()
    {
        int[] denominations = { 5000, 2000, 1000, 500, 200, 100 };
        int[] countables = new int[6];

        Console.WriteLine("Какую сумму вы хотите снять: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        if (amount % 100 != 0 || amount > 150000)
        {
            Console.WriteLine("Мы не сможем выдать вам сумму полностью");
            return;
        }

        for (int i = 0; i < denominations.Length; i++)
        {
            countables[i] = (amount / denominations[i]);
            amount -= denominations[i] * countables[i];
        }

        Console.Write("Вам выдали:");

        for (int i = 0; i < countables.Length; i++)
        {
            if (countables[i] == 0)
            {
                continue;
            }
            else
            {
                Console.Write($" {countables[i]} по {denominations[i]} ");
            }
        }
    }
}
