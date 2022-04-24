using DataBase.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services
{
    public class TUserUsuarioRepository : IRepository<TUser>
    {
        public TestCrudContext context { get; set; }
        public TUserUsuarioRepository()
        {
            context = new TestCrudContext();
        }
        public async Task<int> Add(TUser element)
        {
            try
            {   
                await context.TUsers.AddAsync(element);
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
                context.TUsers.Remove(context.TUsers.FirstOrDefault(u => u.CodUsuario == id));
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TUser> Get(int id)
        {
            try
            {
                return await Task.FromResult(context.TUsers.FirstOrDefault(u => u.CodUsuario == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TUser> Get(TUser user)
        {
            try
            {
                return await Task.FromResult(context.TUsers.FirstOrDefault(u => u.TxtUser == user.TxtUser && u.TxtPassword == user.TxtPassword));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IQueryable<TUser>> GetAll()
        {
            try
            {
                return await Task.FromResult(context.TUsers.Select(x => x));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Update(int id, TUser element)
        {
            try
            {
                context.TUsers.Update(element);
                return await Task.FromResult(await context.SaveChangesAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
