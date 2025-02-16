public class Book
{
    private string _title;
    private string _author;
    private sting _checkOutDate;

    pubic book(string title, string author)
    {
        _title = title;
        _author = author;
        _checkOutDate = "";

    }

    public void checkOut()
    {
        _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedOut()
    {
       bool isCheckedOut;

       if (_checkOutDate == "")
       {
           isCheckedOut = false;
       }
       else
       {
           isCheckedOut = true;
       }
       return isCheckedOut;
    }

    public void Display()
    {
        if(IsCheckedout())
        {
            Console.WriteLine($"{_title} by {_author} checked out: {_checkOutDate}");
        }
        else
        {
            Console.WriteLine($"{_title} by {_author} not checked out");
        }
        
       


    }

    public void AddBook(Book thebook)
    {
        _books.Add(thebook);
    }
}