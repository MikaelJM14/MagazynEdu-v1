using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazynEdu.ApplicationServices.API.Domain;
using System.Threading;
using MagazynEdu.DataAccess;
using MagazynEdu.DataAccess.Entities;

namespace MagazynEdu.ApplicationServices.API.Handlers
{
    public class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<DataAccess.Entities.Book> bookRepository;

        public GetBooksHandler(IRepository<DataAccess.Entities.Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = this.bookRepository.GetAll();
            //var domainBooks = books.Select(x => new Domain.Models.Book()
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Author = x.Author,
            //    Type = x.Type,
            //    SubType = x.SubType,
            //    PageNumber = x.PageNumber,
            //    Publisher = x.Publisher
            //    BookCaseId = x.BookCaseId,
            //    AuthorId = x.AuthorId
            //});

            var domainBooks = new List<Domain.Models.Book>();

            foreach (var book in books)
            {
                domainBooks.Add(new Domain.Models.Book()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Type = book.Type,
                    SubType = book.SubType,
                    PageNumber  = book.PageNumber,
                    Publisher = book.Publisher,
                    BookCaseId = book.BookCaseId,
                    AuthorId = book.AuthorId
                });
            }

            var response = new GetBooksResponse()
            {
                Data = domainBooks.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
