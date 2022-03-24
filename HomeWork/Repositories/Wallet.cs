using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork.Repositories
{
    public class Wallet : User, IValidation<double>
    {
        public static List<Wallet> Wallets = new List<Wallet>();

        private int _userId;

        private double _balance;


        public static bool SetWallet(int userId, double balance)
        {
            var wallet = new Wallet();
            wallet._userId = userId;

            while (!wallet.Validate(balance))
            {
                Console.WriteLine("Wrong Amount! Please enter again");
                double amount = Convert.ToDouble(Console.ReadLine());
            }
            wallet._balance = balance;
            Wallets.Add(wallet);
            return true;

        }

        public double Deposit(double amount)
        {
            _balance += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deposit successfully");
            Console.WriteLine($"${_balance}");
            Console.ResetColor();

            return _balance;
        }

        public double Withdrawal(double amount)
        {
            var result = _balance - amount;
            if (result < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your balance is not enough");
                Console.ResetColor();

            }
            else
            {
                _balance -= amount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Withdrawal successfully");
                Console.WriteLine($"Your balance is ${_balance}");
                Console.ResetColor();

            }

            return _balance;
        }

        public static void PrintAllWallets()
        {
            foreach (var w in Wallets)
            {
                var user = User.GetUser(w._userId);
                Console.WriteLine($"{w._userId} {user._name} ${w._balance}");
            }
        }
        public bool Validate(double entity)
        {
            if (entity < 0)
            {
                return false;
            }

            return true;
        }

        public static Wallet GetWallet(int userId)
        {
            var wal = Wallets.Where(w => w._userId == userId).First();
            var user = GetUser(userId);
            return wal;
        }
    }
}
