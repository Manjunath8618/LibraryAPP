using LibraryAPP.Data;
using LibraryAPP.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryAPP.Repo
{
    public class Books : IBooks
    {
        private readonly BookDBContext _context;

        public Books(BookDBContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = await _context.AllBooks.ToListAsync();
            if(books==null)
            {
               throw new Exception(" No data found");
            }
            return books;
        }
        public async Task<BookModel> GetBookByID(int id )
        {
            var book = await _context.AllBooks.Where(x => x.Id == id).Select(x => new BookModel()
            {
                Id = x.Id,
                Title=x.Title,
                Description=x.Description,
                Author = x.Author
            }).FirstOrDefaultAsync();

            if(book==null)
            {
                throw new Exception(" No Todo item found");
            }
            return book;
        }

    }
}
