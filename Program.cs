class Program
{
    public static decimal Balance = 0.0m;

    static void Deposit()
    {
        try
        {
            Console.Write("How much do you want to deposit? ");
            decimal DepositAmount = Convert.ToDecimal(Console.ReadLine());
            if (DepositAmount > 20)
            {
                Balance += DepositAmount;
                Console.WriteLine($"Deposit Successfull \nYou have #{Balance}\n");
            }
            else
            {
                Console.WriteLine("Deposit cannot be less than $20\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}\n");
        } 
    }

    static public void Withdraw()
    {
        try
        {
            Console.Write("How much do you want to withdraw? ");
            decimal WithdrawAmount = Convert.ToDecimal(Console.ReadLine());
            if (WithdrawAmount <= Balance)
            {
                Balance -= WithdrawAmount;
                Console.WriteLine($"Withdraw {WithdrawAmount} Successfully \nYou balance is #{Balance}\n");
            }
            else
            {
                Console.WriteLine("Withdraw failed! Insufficient balance\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message} \n");
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your balance is #{Balance}\n");
    }

    static void Main()
    {
        bool Programed = true;
        while (Programed)
        {
            Console.WriteLine("=== Simple Banking System ===");
            Console.WriteLine("1. Withdraw \n2. Deposit \n3. Check balance \n4. Exit");
            Console.Write("\nEnter between the following options : ");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Withdraw();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    CheckBalance();
                    break;
                case 4:
                    Programed = false;
                    break;
                default:
                    Console.WriteLine("You have entered a wrong input");
                    break;
            }
        }
    }
}