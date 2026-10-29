using System;
using System.Collections.Generic;
using System.Text;

namespace seedData.classes
{
    public class Member : Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static List<Book> BorrowedBooks = new List<Book>();

        public override string GetRole()
        {
            return "member";
        }
        public override string ToString()
        {
            return "Hello member!";
        }
    }
}
