using seedData.classes;

namespace firsthomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("1 show All the Book");
            Console.WriteLine("2 Borrow Book");
            Console.WriteLine("3 Return Book");
            Console.WriteLine("4 Exit");
            while (choice != 4)
            {
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        Data.print(Data.GetBook());
                        break;

                    case 2:
                        var b = new Book();
                        bool ans = b.Borrow(Data.GetBook());
                        if(ans==true)
                            Console.WriteLine("Book Borrowed");
                        else
                            Console.WriteLine("Book can not borrowed because book is already borrowed");
                    break;

                    case 3:
                        var b1 = new Book();
                        bool ans1 = b1.Return(Data.GetBook());
                        if(ans1==true)
                            Console.WriteLine("Book returned");
                        else
                            Console.WriteLine("Book can not returned because book is not borrowed");
                    break;

                    case 4:

                        break;

                    default:
                        Console.WriteLine("this choice is not found");
                    break;
                }
                LBook l = new LBook();
                var order = l.g(Data.GetBook());
                order.OrderByDescending(n => n.Year);
                var author = Data.GetBook().Where(n => n.Author == "ola");
                var title = Data.GetBook().Select(n => n.Title);
                var maxprice = Data.GetBook().Max(n => n.Price);
                var avgprice = Data.GetBook().Max(n => n.Price);
                var price = Data.GetBook().Any(n => n.Price>100);

            }
        }
    }
}







