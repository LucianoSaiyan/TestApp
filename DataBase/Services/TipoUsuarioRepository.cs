using DataBase.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services
{
    public class TipoUsuarioRepository : IRepository<TiposUsuario>
    {
        public TestCrudContext context { get; set; }
        public TipoUsuarioRepository()
        {
            context = new TestCrudContext();
        }
        public async Task<int> Add(TiposUsuario element)
        {
            try
            {
                await context.TiposUsuarios.AddAsync(element);
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
                context.TiposUsuarios.Remove(context.TiposUsuarios.FirstOrDefault(u => u.IdTipoUsuario == id));
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TiposUsuario> Get(int id)
        {
            try
            {
                return await Task.FromResult(context.TiposUsuarios.FirstOrDefault(u => u.IdTipoUsuario == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IQueryable<TiposUsuario>> GetAll()
        {
            try
            {
                return await Task.FromResult(context.TiposUsuarios.Select(x => x));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Update(int id, TiposUsuario element)
        {
            try
            {
                context.TiposUsuarios.Update(element);
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
