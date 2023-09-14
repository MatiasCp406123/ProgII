using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Banco.Entidades;

namespace Banco.Datos
{
    public class DBHelper
    {
        private SqlConnection conexion;
        public DBHelper()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-4E51ENL\MSSQLSERVERAS;Initial Catalog=Banco;Integrated Security=True");
        }
        public int ProximoCliente()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_CLIENTE";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
           return (int)parametro.Value;    
        }
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable table = new DataTable();
            table.Load(comando.ExecuteReader());
            conexion.Close();
            return table;
        }
        public DataTable Consultar(string nombreSP,List<Parametro>par)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametro p in par)
            {
                comando.Parameters.AddWithValue(p.Nombre,p.Valor);
            }
            DataTable table = new DataTable();
            table.Load(comando.ExecuteReader());
            conexion.Close();
            return table;
        }
        public bool Confirmar(Cliente cliente)
        {
            bool resultado=true;
            SqlTransaction t = null;
            try
            { 
             conexion.Open();
             t = conexion.BeginTransaction();
             SqlCommand comando = new SqlCommand();
             comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
             comando.CommandText = "SP_INSERTAR_CLIENTE";
                comando.Parameters.AddWithValue("@nombre",cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("dni",cliente.Dni);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_cliente";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int id_cliente = (int)parametro.Value;
                int cuentaNro = 1;
                SqlCommand cmdCuenta;

                foreach (Cuenta c in cliente.Cuentas)
                {
                    cmdCuenta = new SqlCommand("SP_INSERTAR_CUENTA",conexion,t);
                    cmdCuenta.CommandType = CommandType.StoredProcedure;
                    cmdCuenta.Parameters.AddWithValue("@cbu",c.Cbu);
                    cmdCuenta.Parameters.AddWithValue("@saldo",c.Saldo);
                    cmdCuenta.Parameters.AddWithValue("@ultimomovimiento", c.UltimoMovimiento);
                    cmdCuenta.Parameters.AddWithValue("@id_tipo_cuenta", c.TipoCuenta);
                    cmdCuenta.Parameters.AddWithValue("@id_cliente", id_cliente);
                    
                    cmdCuenta.ExecuteNonQuery();
                    cuentaNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {

                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

            }


            return resultado;
        }


    }
}
