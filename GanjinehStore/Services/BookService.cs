using GanjinehStore.Data;
using GanjinehStore.Models;
using GanjinehStore.Services.Interfaces;
using GanjinehStore.Utilities;
using GanjinehStore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace GanjinehStore.Services
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<Book>> _logger;

        public BookService(ApplicationDbContext context, ILogger<Service<Book>> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public ItemPagingViewModel<Book> GetPaginatedBooks(string title = null,
           int pageNumber = 1,
           int pageSize = 32)
        {
            //list of books
            IQueryable<Book> Books = _context.Books;

            var take = pageSize;
            var skip = (pageNumber - 1) * pageSize;
            var booksCount = BooksCount(title);

            var pagesCount = (int)Math.Ceiling(Decimal.Divide(booksCount, pageSize));

            return new ItemPagingViewModel<Book>
            {
                Items = Books
                .OrderByDescending(b => b.BookId)
                .Skip(skip)
                .Take(take)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public int BooksCount(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                return _context.Books.Count(b => b.Title.Contains(title));
            }
            return _context.Books.Count();
        }

        public Book Add(Book book, IFormFile bookCover)
        {
            try
            {
                book.Cover = FileUploaderUtility.UploadFile(bookCover, "books");

                _context.Books.Add(book);
                _context.SaveChanges();

                return book;
            }
            catch (Exception ex)
            {
                LogError(ex.StackTrace, ex.Message);

                return null;
            }
        }

        public Book Update(Book book, IFormFile bookCover)
        {
            try
            {
                book.Cover = FileUploaderUtility.UpdatUploadedFile(book.Cover,bookCover, "books");

                _context.Books.Add(book);
                _context.SaveChanges();

                return book;
            }
            catch (Exception ex)
            {
                LogError(ex.StackTrace, ex.Message);

                return null;
            }
        }
    }
}
