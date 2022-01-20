using Acme.BookStore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace moduleA.Books
{
    [Area(moduleARemoteServiceConsts.ModuleName)]
    [RemoteService(Name = moduleARemoteServiceConsts.RemoteServiceName)]
    [Route("api/moduleA/getbook")]
    public class GetListBookController : moduleAController, IGetBookAppService
    {
        private readonly IGetBookAppService _getBookService;
        public GetListBookController(IGetBookAppService getBookService)
        {
            _getBookService = getBookService;
        }

        [HttpGet]
        [Route("getlist")]
        public async Task<List<BookDto>> GetListAsync()
        {
            return await _getBookService.GetListAsync();
        }
    }
}
