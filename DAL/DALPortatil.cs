using DATA;
using DATA.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPortatil : IMantenimientos<DTPortatil>
    {
        public static DALPortatil inst_portatil;

        public static DALPortatil Instancia
        {
            get
            {
                if (inst_portatil == null)
                {
                    return new DALPortatil();
                }
                return inst_portatil;
            }
            set
            {
                if (inst_portatil == null)
                {
                    inst_portatil = value;
                }
            }
        }

        public void Actualizar(DTPortatil objeto)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings1.Default.Proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                //Crear Connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings1.Default.Connection;
                comm = factory.CreateCommand();

                DbParameter par1 = factory.CreateParameter();
                DbParameter par2 = factory.CreateParameter();
                DbParameter par3 = factory.CreateParameter();
                DbParameter par4 = factory.CreateParameter();
                DbParameter par5 = factory.CreateParameter();
                DbParameter par6 = factory.CreateParameter();
                DbParameter par7 = factory.CreateParameter();
                DbParameter par8 = factory.CreateParameter();
                DbParameter par9 = factory.CreateParameter();
                DbParameter par10 = factory.CreateParameter();
                DbParameter par11 = factory.CreateParameter();
                DbParameter par12 = factory.CreateParameter();
                DbParameter par13 = factory.CreateParameter();


                par1.ParameterName = "@ID";
                par1.DbType = System.Data.DbType.Int32;
                par1.Value = objeto.Id;

                par2.ParameterName = "@Marca";
                par2.DbType = System.Data.DbType.Int32;
                par2.Value = objeto.Marca;

                par3.ParameterName = "@Modelo";
                par3.DbType = System.Data.DbType.Int32;
                par3.Value = objeto.Modelo;

                par4.ParameterName = "@Tipo";
                par4.DbType = System.Data.DbType.String;
                par4.Value = objeto.Tipo;

                par5.ParameterName = "@memoriavideointernaGB";
                par5.DbType = System.Data.DbType.Int32;
                par5.Value = objeto.MemoryVideoGB;

                par6.ParameterName = "@lanzamiento";
                par6.DbType = System.Data.DbType.Date;
                par6.Value = objeto.Lanzamiento;

                par7.ParameterName = "@tamanopantalla";
                par7.DbType = System.Data.DbType.Int32;
                par7.Value = objeto.Pantalla;

                par8.ParameterName = "@sistemaoperativo";
                par8.DbType = System.Data.DbType.String;
                par8.Value = objeto.SistOp;

                par9.ParameterName = "@procesador";
                par9.DbType = System.Data.DbType.Int32;
                par9.Value = objeto.Procesador;

                par10.ParameterName = "@ram";
                par10.DbType = System.Data.DbType.Int32;
                par10.Value = objeto.Ram;

                par11.ParameterName = "@camaraprimaria";
                par11.DbType = System.Data.DbType.Int32;
                par11.Value = objeto.Camara;

                par12.ParameterName = "@cantidadusb";
                par12.DbType = System.Data.DbType.Int32;
                par12.Value = objeto.Cantidad_usb;

                par13.ParameterName = "@bateriaamperios";
                par13.DbType = System.Data.DbType.Int32;
                par13.Value = objeto.Bateria;

                comm.Connection = conn;
                conn.Open();

                //Ejecuto Sproc
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Actualiza_Portatil";
                comm.Parameters.Add(par1);
                comm.Parameters.Add(par2);
                comm.Parameters.Add(par3);
                comm.Parameters.Add(par4);
                comm.Parameters.Add(par5);
                comm.Parameters.Add(par6);
                comm.Parameters.Add(par7);
                comm.Parameters.Add(par8);
                comm.Parameters.Add(par9);
                comm.Parameters.Add(par10);
                comm.Parameters.Add(par11);
                comm.Parameters.Add(par12);
                comm.Parameters.Add(par13);

                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Eliminar(DTPortatil objeto)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings1.Default.Proveedor);
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                //Crear Connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings1.Default.Connection;
                comm = factory.CreateCommand();

                DbParameter par0 = factory.CreateParameter();

                par0.ParameterName = "@Id";
                par0.DbType = System.Data.DbType.Int32;
                par0.Value = objeto.Id;

                //Abrimos Connection to SQL
                comm.Connection = conn;
                conn.Open();
                //Execute StoreProcedure-SP-Sprocs
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "sp_Borra_Portatil";
                comm.Parameters.Add(par0);
                comm.ExecuteNonQuery();

            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Insertar(DTPortatil objeto)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings1.Default.Proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                //Crear Connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings1.Default.Connection;
                comm = factory.CreateCommand();

                //DbParameter par1 = factory.CreateParameter();
                DbParameter par2 = factory.CreateParameter();
                DbParameter par3 = factory.CreateParameter();
                DbParameter par4 = factory.CreateParameter();
                DbParameter par5 = factory.CreateParameter();
                DbParameter par6 = factory.CreateParameter();
                DbParameter par7 = factory.CreateParameter();
                DbParameter par8 = factory.CreateParameter();
                DbParameter par9 = factory.CreateParameter();
                DbParameter par10 = factory.CreateParameter();
                DbParameter par11 = factory.CreateParameter();
                DbParameter par12 = factory.CreateParameter();
                DbParameter par13 = factory.CreateParameter();


                //par1.ParameterName = "@ID";
                //par1.DbType = System.Data.DbType.Int32;
                //par1.Value = objeto.Id;

                par2.ParameterName = "@Marca";
                par2.DbType = System.Data.DbType.Int32;
                par2.Value = objeto.Marca;

                par3.ParameterName = "@Modelo";
                par3.DbType = System.Data.DbType.Int32;
                par3.Value = objeto.Modelo;

                par4.ParameterName = "@Tipo";
                par4.DbType = System.Data.DbType.String;
                par4.Value = objeto.Tipo;

                par5.ParameterName = "@memoriavideointernaGB";
                par5.DbType = System.Data.DbType.Int32;
                par5.Value = objeto.MemoryVideoGB;

                par6.ParameterName = "@lanzamiento";
                par6.DbType = System.Data.DbType.Date;
                par6.Value = objeto.Lanzamiento;

                par7.ParameterName = "@tamanopantalla";
                par7.DbType = System.Data.DbType.Int32;
                par7.Value = objeto.Pantalla;

                par8.ParameterName = "@sistemaoperativo";
                par8.DbType = System.Data.DbType.String;
                par8.Value = objeto.SistOp;

                par9.ParameterName = "@procesador";
                par9.DbType = System.Data.DbType.Int32;
                par9.Value = objeto.Procesador;

                par10.ParameterName = "@ram";
                par10.DbType = System.Data.DbType.Int32;
                par10.Value = objeto.Ram;

                par11.ParameterName = "@camaraprimaria";
                par11.DbType = System.Data.DbType.Int32;
                par11.Value = objeto.Camara;

                par12.ParameterName = "@cantidadusb";
                par12.DbType = System.Data.DbType.Int32;
                par12.Value = objeto.Cantidad_usb;

                par13.ParameterName = "@bateriaamperios";
                par13.DbType = System.Data.DbType.Int32;
                par13.Value = objeto.Bateria;

                comm.Connection = conn;
                conn.Open();

                //Ejecuto Sproc
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Ingresa_Portatil";
                //comm.Parameters.Add(par1);
                comm.Parameters.Add(par2);
                comm.Parameters.Add(par3);
                comm.Parameters.Add(par4);
                comm.Parameters.Add(par5);
                comm.Parameters.Add(par6);
                comm.Parameters.Add(par7);
                comm.Parameters.Add(par8);
                comm.Parameters.Add(par9);
                comm.Parameters.Add(par10);
                comm.Parameters.Add(par11);
                comm.Parameters.Add(par12);
                comm.Parameters.Add(par13);

                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public List<DTPortatil> MostrarPorID(DTPortatil id)
        {
            List<DTPortatil> lista = new List<DTPortatil>();
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings1.Default.Proveedor);
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                //Crear Connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings1.Default.Connection;
                comm = factory.CreateCommand();

                DbParameter par0 = factory.CreateParameter();

                par0.ParameterName = "@Id";
                par0.DbType = DbType.Int32;
                par0.Value = id.Id;


                //Abrimos Connection to SQL
                comm.Connection = conn;
                conn.Open();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "sp_Select_By";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    DTPortatil objeto;
                    while (dataReader.Read())
                    {
                        objeto = new DTPortatil
                        {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Marca = Convert.ToInt32(dataReader["marca"]),
                            Modelo = Convert.ToInt32(dataReader["modelo"]),
                            Tipo = dataReader["Tipo"].ToString(),
                            MemoryVideoGB = Convert.ToInt32(dataReader["memoriavideointernaGB"]),
                            Lanzamiento = Convert.ToDateTime(dataReader["lanzamiento"]),
                            Pantalla = Convert.ToInt32(dataReader["tamanopantalla"]),
                            SistOp = dataReader["sistemaoperativo"].ToString(),
                            Procesador = Convert.ToInt32(dataReader["procesador"]),
                            Ram = Convert.ToInt32(dataReader["ram"]),
                            Camara = Convert.ToInt32(dataReader["camaraprimaria"]),
                            Cantidad_usb = Convert.ToInt32(dataReader["cantidadusb"]),
                            Bateria = Convert.ToInt32(dataReader["bateriaamperios"]),
                        };
                        lista.Add(objeto);
                    }
                }
                // retorno de datos
                return lista;
            }
            catch (Exception ee)
            {
                return lista;
            }
        }

        public List<DTPortatil> MostrarTodo()
        {
            List<DTPortatil> lista = new List<DTPortatil>();
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings1.Default.Proveedor);
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                //Crear Connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings1.Default.Connection;
                comm = factory.CreateCommand();
                //Abrimos Connection to SQL
                comm.Connection = conn;
                conn.Open();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "sp_Select_all";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    DTPortatil objeto;
                    while (dataReader.Read())
                    {
                        objeto = new DTPortatil
                        {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Marca = Convert.ToInt32(dataReader["marca"]),
                            Modelo = Convert.ToInt32(dataReader["modelo"]),
                            Tipo = dataReader["Tipo"].ToString(),
                            MemoryVideoGB = Convert.ToInt32(dataReader["memoriavideointernaGB"]),
                            Lanzamiento = Convert.ToDateTime(dataReader["lanzamiento"]),
                            Pantalla = Convert.ToInt32(dataReader["tamanopantalla"]),
                            SistOp = dataReader["sistemaoperativo"].ToString(),
                            Procesador = Convert.ToInt32(dataReader["procesador"]),
                            Ram = Convert.ToInt32(dataReader["ram"]),
                            Camara = Convert.ToInt32(dataReader["camaraprimaria"]),
                            Cantidad_usb = Convert.ToInt32(dataReader["cantidadusb"]),
                            Bateria = Convert.ToInt32(dataReader["bateriaamperios"]),
                        };
                        lista.Add(objeto);
                    }
                }
                // retorno de datos
                return lista;
            }
            catch (Exception ee)
            {
                return lista;
            }
        }
    }
}
