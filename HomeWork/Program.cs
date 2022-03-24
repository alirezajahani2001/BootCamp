using HomeWork.Repositories;

User.AddUser(0, "Alireza Jahani");
User.AddUser(1, "Mahdi Taheri");
User.AddUser(2, "Amin Taheri");
User.AddUser(3, "Negar Bastani");
User.AddUser(4, "Ehsan Seyfollahi");
User.AddUser(5, "Sanaz Ghasemi");
// User.PrintAllUsers();
Wallet.SetWallet(0, 2000);
Wallet.SetWallet(1, 1800);
Wallet.SetWallet(2, 1265);
Wallet.SetWallet(3, 150);
Wallet.SetWallet(4, 700);
Wallet.SetWallet(5, 1200);

try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hello  Welcome =)");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("type 'exit' to quit ");
    Console.ResetColor();
    Console.WriteLine("********************************");

    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Wallet.PrintAllWallets();
        Console.ResetColor();

        Console.WriteLine("********************************");
        Console.WriteLine("Please Select User by ID");
        var typedValue = Console.ReadLine();
        if (typedValue == "exit")
        {
            break;
        }

        var selected = Wallet.GetWallet(Convert.ToInt32(typedValue));


        Console.WriteLine("Please Choose");
        Console.WriteLine("1 ===> Deposit");
        Console.WriteLine("2 ===> Withdrawal");

        var key = Convert.ToInt32(Console.ReadLine());

        switch (key)
        {
            case 1:
                Console.WriteLine("Enter Your Amount to deposit");
                var deposit = Convert.ToDouble(Console.ReadLine());
                selected.Deposit(deposit);
                break;
            case 2:
                Console.WriteLine("Enter Your Amount to withdrawal");
                var withdrawal = Convert.ToDouble(Console.ReadLine());
                selected.Withdrawal(withdrawal);
                break;
            default:
                Console.WriteLine("Wrong Value");
                break;
        }

        Console.WriteLine("Do you want to try another User?");
        Console.WriteLine("1 ===>Yes");
        Console.WriteLine("0 ===>No");
        var answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 0)
        {
            break;
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}
finally
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Thanks for  using my FirstApp developed by C# :)");
    Console.WriteLine("Please email your comments to AlirezaJahani2001@gmail.com");
    Console.ResetColor();
}
