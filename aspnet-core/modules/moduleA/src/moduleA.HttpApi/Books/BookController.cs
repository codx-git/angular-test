using Acme.BookStore;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;

namespace moduleA.Books
{
    [Area(moduleARemoteServiceConsts.ModuleName)]
    [RemoteService(Name = moduleARemoteServiceConsts.RemoteServiceName)]
    [Route("api/moduleA/Book")]

    public class BookController : moduleAController,IBookAppService
    {
        private readonly IBookAppService _bookAppService;
       
        public BookController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            return await _bookAppService.CreateAsync(input);
        }

        [HttpDelete]
        [Route("{Delete}")]
        public async Task DeleteAsync(Guid id)
        {
            await _bookAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BookDto> GetAsync(Guid id)
        {
            return await _bookAppService.GetAsync(id);
        }

        [HttpGet]
        [Route("GetList")]
        public  async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await _bookAppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            return await _bookAppService.UpdateAsync(id, input);
        }


    }
}
