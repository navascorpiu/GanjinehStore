using GanjinehStore.Models;
using GanjinehStore.ViewModels;
using Microsoft.AspNetCore.Http;

namespace GanjinehStore.Services.Interfaces
{
    public interface IBookService : IService<Book>
    {
        BookPagingViewModel GetPaginatedBooks(string title = null, int PageNumber = 1, int PageSize = 32);
        int BooksCount(string title);

        Book Add(Book book, IFormFile bookCover);

        Book Update(Book book, IFormFile bookCover);
    }
}