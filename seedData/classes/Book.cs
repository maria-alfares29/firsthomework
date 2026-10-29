using System;
using System.Collections.Generic;
using System.Text;

namespace seedData.classes
{
    public class Book : IBorrowable
    {
        public bool IsAvailable { get; set; }
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                {
                    Console.WriteLine("Price must be greater than 0");
                }
            }
        }
        public int Year { get; set; }
        public string Author { get; set; }


        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {

                if (!string.IsNullOrEmpty(value))
                    _title = value;
                else
                    Console.WriteLine("Title is required");
            }
        }
        public int Id { get; set; }

        public   bool Borrow(List<Book> list)
        {
            Console.WriteLine("Enter the book id :");
            int id = int.Parse(Console.ReadLine()!);
            bool canborrow=true;
            foreach (var item in list)
            {
                if (item.Id == id && item.IsAvailable == true)
                {
                    canborrow = true;
                   item.IsAvailable = false;
                    if (canborrow == true)
                        break;
                }
                else
                   canborrow = false;
            }
            return canborrow;
        }

        public  bool Return(List <Book>list)
        {
            Console.WriteLine("Enter the book id :");
            int id = int.Parse(Console.ReadLine()!);
            bool canreturn = false;
            foreach(var item in list)
            {
                if (item.Id == id && item.IsAvailable == false)
                {   
                    canreturn = true;
                    IsAvailable = true;
                    if (canreturn == true)
                        break;
                }
                else
                    canreturn = false;

            }
        
            return canreturn;
        }
        public override string ToString()
        {
            return $"Titlie:{Title},Author:{Author}";
        }
    }
}
    
        

