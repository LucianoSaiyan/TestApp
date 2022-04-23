using DataBase.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        public TestCrudContext context { get; set; }
        public UsuarioRepository()
        {
            context = new TestCrudContext();
        }
        public async Task<int> Add(Usuario element)
        {
            try
            {   
                await context.Usuarios.AddAsync(element);
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                context.Usuarios.Remove(context.Usuarios.FirstOrDefault(u => u.IdUsuario == id));
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> Get(int id)
        {
            try
            {
                return await Task.FromResult(context.Usuarios.FirstOrDefault(u => u.IdUsuario == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IQueryable<Usuario>> GetAll()
        {
            try
            {
                return await Task.FromResult(context.Usuarios.Select(x => x));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Update(int id, Usuario element)
        {
            try
            {
                context.Usuarios.Update(element);
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
