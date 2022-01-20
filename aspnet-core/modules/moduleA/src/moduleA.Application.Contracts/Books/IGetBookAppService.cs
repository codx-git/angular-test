using Acme.BookStore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
namespace moduleA.Books
{
    public interface IGetBookAppService : IApplicationService
    {
        Task<List<BookDto>> GetListAsync();
    }
}
