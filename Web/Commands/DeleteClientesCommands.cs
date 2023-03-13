using MediatR;
using Web.Models;

namespace Web.Commands
{
    public class DeleteClientesCommands : IRequest<Cliente>
    {
        public int Id { get; set; }
    }
}
