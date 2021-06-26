using BD;
using Entity;
using Entity.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ITituloService
    {
        Task<DBEntity> Create(TituloEntity entity);
        Task<DBEntity> Delete(TituloEntity entity);
        Task<IEnumerable<TituloEntity>> Get();
        Task<TituloEntity> GetById(TituloEntity entity);
        Task<DBEntity> Update(TituloEntity entity);
    }

    public class TituloService : ITituloService
    {
        private readonly IDataAccess sql;

        public TituloService(IDataAccess _sql)
        {
            sql = _sql;
        }


        public async Task<IEnumerable<TituloEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<TituloEntity>("ObtenerTitulo");

                return await result;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TituloEntity> GetById(TituloEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<TituloEntity>("ObtenerTitulo", new
                {
                    entity.Id_Titulo
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Create(TituloEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarTitulo", new
                {
                    entity.Descripcion,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Update(TituloEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarTitulo", new
                {
                    entity.Id_Titulo,
                    entity.Descripcion,
                    entity.Estado
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Delete(TituloEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarTitulo", new
                {
                    entity.Id_Titulo,
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
