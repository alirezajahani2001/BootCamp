using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Interfaces;

namespace HomeWork.Repositories
{
    public class User : IValidation<int>
    {
        public static List<User> Users = new List<User>();
        protected int _id;
        public string _name;

        protected User()
        {

        }
        public static User AddUser(int id, string name)
        {
            var user = new User();
            user._id = id;
            user._name = name;
            Users.Add(user);
            // Console.WriteLine($"ID: {user._id} Name: {user._name}");
            return user;

        }
        public static User GetUser(int Id)
        {
            var user = Users.Where(n => n._id == Id).First();
            // Console.WriteLine($"ID: {user._id} Name: {user._name}");

            return user;
        }

        public static void PrintAllUsers()
        {
            foreach (var u in Users)
            {
                Console.WriteLine($"ID: {u._id} Name: {u._name}");
            }
        }

        public bool Validate(int entity)
        {

            // Ask to fix it
            return true;
        }
    }
}


