using System;

namespace LibraryManagement
{
    interface ILibrary
    {
        void Bookname();      
        void Authorname();    
        void Search();        
    }

    class Library : ILibrary
    {
        public string[] books = new string[50];
        public string[] authors = new string[50];
        public int bookCount = 0;
        public int authorCount = 0;

        public void Bookname()
        {
            if (bookCount >= books.Length)
            {
                Console.WriteLine("Book list is full.\n");
                return;
            }
            else
            {
                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();
                books[bookCount] = bookName;
                bookCount++;
                Console.WriteLine("Book saved.\n");
            }

           
        }

        public void Authorname()
        {
            if (authorCount >= authors.Length)
            {
                Console.WriteLine("Author list is full.\n");
                return;
            }
            else
            {

                Console.Write("Enter Author Name: ");
                string authorName= Console.ReadLine();
                authors[authorCount]=authorName;
                authorCount++;
                Console.WriteLine("Author saved.\n");

            }

        }

        public void Search()
        {
            Console.Write("Enter a book or author to search: ");
            string keyword = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].ToString() == keyword.ToString())
                {
                    Console.WriteLine($"Book '{keyword}' found at position {i + 1}.");
                    found = true;
                }
            }

            for (int i = 0; i < authorCount; i++)
            {
                if (authors[i].ToLower() == keyword.ToLower())
                {
                    Console.WriteLine($"Author '{keyword}' found at position {i + 1}.");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"'{keyword}' not found in books or authors.");
            }

        }

    }

    class Program
    {
        static void Main()
        {
            ILibrary library = new Library();

            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Author");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.\n");
                    continue;
                }


                switch (choice)
                {
                    case 1: library.Bookname(); break;
                    case 2: library.Authorname(); break;
                    case 3: library.Search(); break;
                    case 4: return;
                    default: Console.WriteLine("Invalid option.\n"); break;
                }
              
            }
        }
    }
}

