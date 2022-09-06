using System;

namespace Assignment1
{
    public class App
    {
        public void Console()
        {
            int choice;
            Book b1 = new Book();
            do
            {
                System.Console.WriteLine("\n\nThis is Question6 of Assignment1\n");
                System.Console.WriteLine("Choose an operation from below :\n" +
                                         "1. Add Details of Book\n" +
                                         "2. Display Details of Book\n");
                choice = int.Parse(System.Console.ReadLine());
                if(choice!=1 && choice!=2)
                {
                    System.Console.WriteLine("Enter a valid choice.");
                }
            } while(choice != 1 && choice != 2);
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("Enter the bookId below :");
                    int bId = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Enter the bookName below :");
                    string bName = System.Console.ReadLine();
                    System.Console.WriteLine("Enter the bookPrice below :");
                    double bPrice = double.Parse(System.Console.ReadLine());
                    int op;
                    string bType = null;
                    do
                    {
                        System.Console.WriteLine("Choose one of the bookTypes from below :\n" +
                                          "1. Magazine\n" +
                                          "2. Novel\n" +
                                          "3. ReferenceBook\n" +
                                          "4. Miscellaneous\n");
                        op = int.Parse(System.Console.ReadLine());
                        if (op != 1 && op != 2 && op != 3 && op != 4)
                        {
                            System.Console.WriteLine("Enter a valid bookType");
                        }
                    } while (op != 1 && op != 2 && op != 3 && op != 4);
                    switch (op)
                    {
                        case 1:
                            bType = (Book.Types.Magazine).ToString();
                            break;
                        case 2:
                            bType = (Book.Types.Novel).ToString();
                            break;
                        case 3:
                            bType = (Book.Types.ReferenceBook).ToString();
                            break;
                        case 4:
                            bType = (Book.Types.Miscellaneous).ToString();
                            break;
                    }

                    b1.bookId = bId;
                    b1.title = bName;
                    b1.price = bPrice;
                    b1.bookType = (Book.Types)Enum.Parse(typeof(Book.Types),bType);
                    break;
                case 2:
                    b1.DisplayDetails();
                    break;
            }

        }
    }
    public struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public Types bookType;

        public enum Types
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }

        public Book(int bookId, string title, double price, string bookType)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
            this.bookType = (Types)Enum.Parse(typeof(Types), bookType);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("The details of the book are as follows : " +
                              "bookId   - {0}" +
                              "title    - {1}" +
                              "price    - {2}" +
                              "BookType - {3}", this.bookId, this.title, this.price, this.bookType);
        }
    }
}
