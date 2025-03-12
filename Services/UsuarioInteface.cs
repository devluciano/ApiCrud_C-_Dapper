using CrudDAPPERApi.Dto;
using CrudDAPPERApi.Models;

namespace CrudDAPPERApi.Services
{
    public interface UsuarioInteface
    {
        Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios();
        Task<ResponseModel<UsuarioListarDto>> BuscarUsuarioPorId(int UsuarioId);
    }
}
