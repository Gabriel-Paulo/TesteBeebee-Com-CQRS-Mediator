using MediatR;
using Web.Models;

namespace Web.Commands
{
    public class CreateDocumentosCommands : IRequest<Documento>
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public int ClienteId { get; set; }

    }
}
