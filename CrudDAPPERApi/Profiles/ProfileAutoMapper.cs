using AutoMapper;
using CrudDAPPERApi.Dto;
using CrudDAPPERApi.Models;
using System.Runtime;

namespace CrudDAPPERApi.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<Usuario, UsuarioListarDto>();
        }
    }
}
