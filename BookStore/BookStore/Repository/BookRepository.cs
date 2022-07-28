using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where( x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }



        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "C" , Author = "Subeen" },
                new BookModel() { Id = 2, Title = "C++" , Author = "Shahadat" },
                new BookModel() { Id = 3, Title = "Java" , Author = "Nirob" },
                new BookModel() { Id = 4, Title = "Python" , Author = "Neal" },
                new BookModel() { Id = 5, Title = "C#" , Author = "Heisenberg" }
            };
        }
    }
}
