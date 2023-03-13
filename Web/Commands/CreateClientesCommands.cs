using MediatR;
using Web.Models;

namespace Web.Commands
{
    public class CreateClientesCommands : IRequest<Cliente>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public List<Documento> Documentos { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }

}
