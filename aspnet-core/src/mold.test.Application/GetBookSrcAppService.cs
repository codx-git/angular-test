using Acme.BookStore;
using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using AutoMapper;
using Volo.Abp.ObjectMapping;

namespace moduleA.Books
{
    public class GetBookSrcAppService : ApplicationService, IGetBookAppService
    {
        private readonly IRepository<Book, Guid> _repository;

        public GetBookSrcAppService(IRepository<Book,Guid> repository)
        {
            _repository = repository;
        }
        public async Task<List<BookDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return ObjectMapper.Map<List<Book>,List< BookDto>>(items);
        }
    }
}
