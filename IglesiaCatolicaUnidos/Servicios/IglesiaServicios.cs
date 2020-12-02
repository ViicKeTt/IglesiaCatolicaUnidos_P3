using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IglesiaCatolicaUnidos.Data;
using Microsoft.EntityFrameworkCore;

namespace IglesiaCatolicaUnidos.Servicios
{
    public interface I_IglesiaServicios
    {
        Task<List<Integrante>> GetAllIntegrante(Guid Uid);
        Task<Integrante> ReadIntegrante(Guid Iid);
        Task<bool> CreateIntegrante(Integrante I);
        Task<bool> DeleteIntegrante(Integrante I);
        Task<Integrante> UpdateIntegrante(Integrante I);
    }
    public class IglesiaServicios : I_IglesiaServicios
    {
        private readonly ApplicationDbContext db;
        public IglesiaServicios(ApplicationDbContext _dbContext)
        {
            db = _dbContext;
        }
        public Task<bool> CreateIntegrante(Integrante I)
        {///*********************************************************************************************************
            bool status = false;
            try
            {
                db.INTEGRANTES.Add(I);
                db.SaveChanges();
                status = true;
            }
            catch (Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }

        public Task<bool> DeleteIntegrante(Integrante I)
        {
            bool status = false;
            try
            {
                db.INTEGRANTES.Remove(I);
                db.SaveChanges();
                status = true;
            }
            catch (Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }

        public async Task<List<Integrante>> GetAllIntegrante(Guid Uid)
        {
            List<Integrante> Integrantes = await db.INTEGRANTES
             .Where(t => t.MyUsuarioID.Equals(Uid))
             .ToListAsync<Integrante>();
            return await Task.FromResult(Integrantes);
        }

        public Task<Integrante> ReadIntegrante(Guid Iid)
        {
            Integrante treasure = db.INTEGRANTES
            .Where(t => t.MyUsuarioID.Equals(Iid)).FirstOrDefault();
            return Task.FromResult(treasure);
        }

        public async Task<Integrante> UpdateIntegrante(Integrante I)
        {
            try
            {
                var AccidentadoExistente = db.INTEGRANTES.FirstOrDefault(a => a.IntegranteID == I.MyUsuarioID);
                if (AccidentadoExistente != null)
                {
                    db.Update(I);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return I;
        }
    }
}
