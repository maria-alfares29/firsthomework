using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seedData.classes
{
    public class Librarian : Person
    {
        public override string GetRole()
        {

            string role="ll";
            Console.WriteLine("Are you Admin?");
            bool ans = bool.Parse(Console.ReadLine()!);
            int password;

            if (ans == true)
            {
                Console.WriteLine("Enter Password");
                password = int.Parse(Console.ReadLine()!);
                if (password == 2932006)
                {
                    role = "Admin";

                }
                else
                    role = "You are not Admin";

            }
            else
                role = "You are not Admin";
            Console.WriteLine(role);
            return role;
        }
        public static void DeletByAdmin(List<Book> list, int i)
        {
            list.RemoveAt(i);
        }
        public override string ToString()
        {
            return "I am admin";
        }
        

    }
}
