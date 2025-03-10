using LibraryAPP.Model;

namespace LibraryAPP.Repo
{
    public interface IBooks
    {
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);

    }
}
