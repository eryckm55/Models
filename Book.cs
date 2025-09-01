namespace lab1.Models;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }

        public Book(string title, string author, int totalPages)
        {
            Title = title;
            Author = author;
            TotalPages = totalPages;
            CurrentPage = 1;
        }

        public void NextPage()
        {
            if (CurrentPage < TotalPages)
                CurrentPage++;
            else
                Console.WriteLine("You finished the book. There is no next page.");
        }

        public void PrevPage()
        {
            if (CurrentPage > 1)
                CurrentPage--;
            else
                Console.WriteLine("You haven't started the book. There is no previous page.");
        }

        public override string ToString()
        {
            return $"{Title} - {Author}. {CurrentPage}/{TotalPages} pages.";
        }
    }

