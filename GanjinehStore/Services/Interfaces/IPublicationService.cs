using GanjinehStore.Models;
using GanjinehStore.ViewModels;

namespace GanjinehStore.Services.Interfaces
{
    interface IPublicationService : IService<Publication>
    {
        ItemPagingViewModel<Publication> GetPaginatedPublications(string publisherName = null, int pageNumber = 1, int pageSize = 32);

        int PublicationsCount(string publisherName);
    }
}
