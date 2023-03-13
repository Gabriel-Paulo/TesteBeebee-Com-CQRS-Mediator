using MediatR;
using System.Reflection.Metadata;
using Web.Commands;
using Web.Models;

namespace Web.Handlers
{
    public class AtualizarClienteCommandHandler : IRequestHandler<UpdateClientesCommands, Cliente>
    {
        private readonly ClientesContext _context;

        public AtualizarClienteCommandHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(UpdateClientesCommands request, CancellationToken cancellationToken)
        {
            var cliente = await _context.Clientes.FindAsync(request.Id);

            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado");
            }

            cliente.Nome = request.Nome;
            cliente.Email = request.Email;
            cliente.Telefone = request.Telefone;
            cliente.DataNascimento = request.DataNascimento;
            cliente.Documentos = request.Documentos;
            cliente.Enderecos = request.Enderecos;

            await _context.SaveChangesAsync();

            return cliente;
        }
    }
}
