using MediatR;
using Web.Models;

namespace Web.Queries
{
    public class ObterClientePorIdQuery : IRequest<Cliente>
    {
        public int Id { get; set; }
    }
}
