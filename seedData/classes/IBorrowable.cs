using System;
using System.Collections.Generic;
using System.Text;

namespace seedData.classes
{
    public interface IBorrowable
    {
        public bool Return(List<Book> list);
        public  bool Borrow(List<Book> list);
    }

}
