using SCP.Core.ModelEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP.Core.Interfaces
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> GetUsuarioById(int id);
        Task InsertarUsuario(Usuario usuario);
    }
}
