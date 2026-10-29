using System;
using System.Collections.Generic;
using System.Text;

namespace seedData.classes
{
    public class Data
    {
        public static List<Book> GetBook()
        {
            List<Book> books = new List<Book>
            {
                new Book{Title="story"    ,Author="adham" ,Price=220,Id=1,Year=2024, IsAvailable=true},
                new Book{Title="family"   ,Author="solaf" ,Price=150,Id=2,Year=2017, IsAvailable=true},
                new Book{Title="friend"   ,Author="hayyan",Price=200,Id=3,Year=2012, IsAvailable=false},
                new Book{Title="Arabic"   ,Author="fatema",Price=300,Id=4,Year=2023, IsAvailable=true},
                new Book{Title="Enghlish" ,Author="ola"   ,Price=400,Id=5,Year=2020, IsAvailable=true},
                new Book{Title="biology"  ,Author="solaf" ,Price=500,Id=6,Year=2018, IsAvailable=false},
                new Book{Title="car"      ,Author="ola"   ,Price=350,Id=7,Year=2018, IsAvailable=true},
                new Book{Title="book"     ,Author="adham" ,Price=250,Id=8,Year=2012, IsAvailable=false},
                new Book{Title="c#"       ,Author="hayyan",Price=210,Id=9,Year=2012, IsAvailable=true},
                new Book{Title="chemistry",Author="ataa"  ,Price=105,Id=10,Year=1995, IsAvailable=true},
                new Book{Title="geography",Author="ataa"  ,Price=340,Id=11,Year=2008, IsAvailable=true},
                new Book{Title="history"  ,Author="hayyan",Price=540,Id=12,Year=2003, IsAvailable=true},
                new Book{Title="cooking"  ,Author="fatema",Price=405,Id=13,Year=2018, IsAvailable=false},
                new Book{Title="science"  ,Author="adham" ,Price=370,Id=14,Year=2014, IsAvailable=true},
                new Book{Title="math"     ,Author="ola"   ,Price=290,Id=15,Year=1959, IsAvailable=true}
            };
            return books;
        }
        public static  void  print(List<Book>list)
        {   foreach (var item in list)
            Console.WriteLine($"Title={item.Title},Author={item.Author},Price={item.Price},Id={item.Id},Year={item.Year}, IsAvailable={item.IsAvailable}");
        }
        public override string ToString()
        {
            return "the class has Data";
        }
    }
}





