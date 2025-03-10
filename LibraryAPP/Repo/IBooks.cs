using LibraryAPP.Model;

namespace LibraryAPP.Repo
{
    public interface IBooks
    {
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookByID(int id);

    }
}
