using MediatR;
using Web.Models;

namespace Web.Queries
{
    public class ObterTodosClientesQuery : IRequest<List<Cliente>>
    {
    }
}
