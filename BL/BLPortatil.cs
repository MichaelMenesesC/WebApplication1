using DAL;
using DATA;
using DATA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BL
{
    public class BLPortatil : IMantenimientos<DTPortatil>
    {
        public static BLPortatil inst;

        public static BLPortatil Inst
        {
            get
            {
                if (inst == null)
                {
                    return new BLPortatil();
                }
                return inst;
            }

            set
            {
                if (inst == null)
                {
                    inst = value;
                }
                
            }
        }

        public void Actualizar(DTPortatil objeto)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.DALPortatil.Instancia.Actualizar(objeto);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private List<DTPortatil> lista = new List<DTPortatil>();

        public void Eliminar(DTPortatil objeto)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.DALPortatil.Instancia.Eliminar(objeto);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Insertar(DTPortatil objeto)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.DALPortatil.Instancia.Insertar(objeto);
                    scope.Complete();
                }
        }
            catch (Exception ee)
            {
                throw;
            }
}

        public List<DTPortatil> MostrarPorID(DTPortatil id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.DALPortatil.Instancia.MostrarPorID(id);
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                return lista;
            }
        }

        public List<DTPortatil> MostrarTodo()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.DALPortatil.Instancia.MostrarTodo();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                return lista;
            }
        }
    }
}
