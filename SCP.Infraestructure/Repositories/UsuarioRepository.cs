using Microsoft.EntityFrameworkCore;
using SCP.Core.Interfaces;
using SCP.Core.ModelEntity;
using SCP.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly SCPContext _SCPContext;

        public UsuarioRepository(SCPContext context)
        {
            _SCPContext = context;
        }
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var usuarios = await _SCPContext.Usuario.ToListAsync();
            return usuarios;
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            var usuario = await _SCPContext.Usuario.FirstOrDefaultAsync(u => u.IdUsuario == id);
            return usuario;
        }
        public async Task InsertarUsuario(Usuario usuario)
        {
            _SCPContext.Usuario.Add(usuario);
            await _SCPContext.SaveChangesAsync();
        }
    }
}
