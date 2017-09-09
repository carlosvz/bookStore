using BookStore.Data.Repositories;
using BookStore.Domain;
using BookStore.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStore.API.Controllers
{
    [RoutePrefix("api/public/v1")]
    public class BookController : ApiController
    {
        private IBookRepository _repository = new BookRepository();

        [Route("livros")]
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            try
            {
                var livros = _repository.Get(0, 30);
                if (livros != null && livros.Count > 0)
                    response = Request.CreateResponse(HttpStatusCode.OK, livros);
                else
                    response = Request.CreateResponse(HttpStatusCode.NoContent, "Nenhum livro encontrado");

            }
            catch (Exception ex)
            {

                response = Request.CreateResponse(HttpStatusCode.InternalServerError, $"Falha ao conectar no banco de dados: {ex.Message}");
            }
            return response;

        }
        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
        }
    }
}
