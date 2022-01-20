using Acme.BookStore;
using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace moduleA.Books
{
    public class GetBookAppService : ApplicationService, IGetBookAppService
    {
        private readonly IRepository<Book, Guid> _repository;

        public GetBookAppService(IRepository<Book,Guid> repository)
        {
            _repository = repository;
        }
        public async Task<List<BookDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items.Select(items => new BookDto{ 
                Name = items.Name,
                Type = items.Type,
                PublishDate = DateTime.Now,
                Price   = items.Price
            } ).ToList();
        }
    }
}
