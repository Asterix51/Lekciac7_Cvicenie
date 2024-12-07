namespace Lekciac7_Cvicenie
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Pages;
        public int CurrentPage;

        public Book(string title, string author, int pages)
        { 
            Title = title;
            Author = author;
            Pages = pages;
            CurrentPage = 0;
        }

        public void Read(int pages)
        {
            if ((CurrentPage+pages) > Pages)
            {
                CurrentPage = Pages;
            }
            else
            {
                CurrentPage += pages;
            }
        }

        public void DisplayProgress()
        {
            Console.WriteLine($"Reading {Title} by {Author}: {CurrentPage}/{Pages} pages read");
        }
    }
}
