using MediatR;
using Web.Models;

namespace Web.Queries
{
    public class ObterDocumentosPorIdQuery : IRequest<List<Documento>>
    {
        public int Id { get; set; } 
    }
}
