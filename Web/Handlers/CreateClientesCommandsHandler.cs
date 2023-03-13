using MediatR;
using Web.Commands;
using Web.Models;

namespace Web.Handlers
{
    public class CreateClientesCommandsHandler : IRequestHandler<CreateClientesCommands, Cliente>
    {
        private readonly ClientesContext _context;

        public CreateClientesCommandsHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(CreateClientesCommands request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente
            {
                Nome = request.Nome,
                Email = request.Email,
                Telefone = request.Telefone,
                DataNascimento = request.DataNascimento,
                Documentos = request.Documentos,
                Enderecos = request.Enderecos
            };

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }
    }
}
