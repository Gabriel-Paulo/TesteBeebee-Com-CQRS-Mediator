using MediatR;
using Web.Models;

namespace Web.Queries
{
    public class ObterEnderecoPorIdQuery : IRequest<List<Endereco>>
    {
        public int Id { get; set; } 
    }
}
