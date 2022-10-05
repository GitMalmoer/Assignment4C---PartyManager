using Assignment4C;

class MainProgram
{
    static void Main(string[] args)
    {
        PhoneBookApp phoneBook = new PhoneBookApp();

        phoneBook.DisplayList();

        phoneBook.SortByName();
        Console.WriteLine("\n now the list is sorted: ");
        phoneBook.DisplayList();


        Console.WriteLine("\n now the 2d list: ");
        phoneBook.FillTable();

        phoneBook.DisplayTable();

     
    }
}
