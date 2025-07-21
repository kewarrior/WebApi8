using WebApi8.Models;

namespace WebApi8.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorIdLivro(int idLivro);
    }
}
