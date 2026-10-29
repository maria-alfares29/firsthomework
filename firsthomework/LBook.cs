using seedData.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace firsthomework
{
    public   class LBook
    { public List<Book> g(List<Book> list)
        {
            var AvailableBook = new List<Book> { };
            foreach (var item in list)
            {
                if (item.IsAvailable == true) ;
                AvailableBook.Add(item);
            }
            return AvailableBook;
        }

    }
    
}
