using system.runtime.serializatoin;

class Program
{
    static void Main()
    {
        book b1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        book b2 = new Book("To Kill a Mockingbird", "Harper Lee");

        b1.checkOut();

        b1.Display();
        b2.Display();
    }
}