using Acme.BookStore;
using Acme.BookStore.Books;
using AutoMapper;

namespace moduleA
{
    public class moduleAApplicationAutoMapperProfile : Profile
    {
        public moduleAApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
        }
    }
}