using CINE_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Data
{
    internal class HelperSing
    {
        private SqlConnection cnn;
        private static HelperSing instance = null;

        private HelperSing()
        {
            string cadena = @"Data Source=DESKTOP-0L0DMBQ\SQLEXPRESS;Initial Catalog=CineTUP_Oficial;Integrated Security=True";
            cnn = new SqlConnection(cadena);
        }

        public static HelperSing Instance
        {
            get
            {
                if (instance == null)
                    instance = new HelperSing();               
                return instance;
            }
        }

        public DataTable ConsultarDB(string SP)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable ConsultarDBP(string SP, List<Parametro> lst)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (Parametro p in lst)
            {
                cmd.Parameters.AddWithValue(p.key, p.value);
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public bool InsertCliente(string SP, Cliente cliente)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(SP);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@fec_nac", cliente.FechaNac);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } //Creo que no Hace falta mas

        public bool InsertPeliculas(string SP,Pelicula peli)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(SP,cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", peli.Titulo);
                cmd.Parameters.AddWithValue("@sinopsis", peli.Sinopsis);
                cmd.Parameters.AddWithValue("@fec_estreno", peli.FechaEstreno);
                cmd.Parameters.AddWithValue("@elenco", peli.Elenco);
                cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                cmd.Parameters.AddWithValue("@calificacion", peli.Calificacion.IdCalif);
                cmd.Parameters.AddWithValue("@apta_todo_publico", peli.AptoTodoPublico);
                cmd.Parameters.AddWithValue("@idioma", peli.Idioma);
                cmd.Parameters.AddWithValue("@subtitulo", peli.Subtitulo);
                cmd.Parameters.AddWithValue("@origen", peli.Origen.IdOrigen);
                cmd.Parameters.AddWithValue("@genero", peli.Genero.Id_genero);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } //Creo que no Hace falta mas

        public bool ActualizarDB(string SP, List<Parametro> lst) 
        { 
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(SP,cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in lst)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertReserva(string SPM,string SPD, Reserva reserva)
        {
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand CmdM = new SqlCommand(SPM, cnn, t);
                CmdM.CommandType = CommandType.StoredProcedure;                
                CmdM.Parameters.AddWithValue("@fec_reserva", reserva.FechaReserva);               
                CmdM.Parameters.AddWithValue("@id_cliente", reserva.Cliente.IdCliente);               

                SqlParameter Param = new SqlParameter("@IdOut", DbType.Int32);
                Param.Direction = ParameterDirection.Output;
                CmdM.Parameters.Add(Param);
                CmdM.ExecuteNonQuery();
                
                int IdReserva = (int)Param.Value;

                SqlCommand CmdD = new SqlCommand(SPD, cnn, t);
                CmdD.CommandType = CommandType.StoredProcedure;
                foreach (DetalleReserva det in reserva.Ldetalle)
                {                    
                    CmdD.Parameters.AddWithValue("@id_reserva", IdReserva);
                    CmdD.Parameters.AddWithValue("@id_funcion", det.Funcion.IdFuncion);
                    CmdD.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    CmdD.ExecuteNonQuery();
                }

                t.Commit();
                return true;
            }
            catch (Exception)
            {
                t.Rollback();
                return false;
            }
            finally
            {
                if (cnn.State.Equals(ConnectionState.Open))
                    cnn.Close();
            }
        }

        public bool InsertFactura(string SPM, string SPD, Factura factura)
        {
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand CmdM = new SqlCommand(SPM, cnn, t);
                CmdM.CommandType = CommandType.StoredProcedure;
                //CmdM.Parameters.AddWithValue("@id_factura", factura.IdFactura); identity???
                CmdM.Parameters.AddWithValue("@fecha", factura.Fecha);
                CmdM.Parameters.AddWithValue("@id_cliente", factura.Cliente.IdCliente);
                CmdM.Parameters.AddWithValue("@id_reserva", factura.Reserva.Id_reserva);
                CmdM.Parameters.AddWithValue("@id_forma_pago", factura.FormaPago.IdFormaPago);
                CmdM.Parameters.AddWithValue("@id_promocion", factura.Promocion.IdPromocion);

                SqlParameter Param = new SqlParameter("@IdOut", DbType.Int32);
                Param.Direction = ParameterDirection.Output;
                CmdM.Parameters.Add(Param);
                CmdM.ExecuteNonQuery();

                int IdFactura = (int)Param.Value;

                SqlCommand CmdD = new SqlCommand(SPD, cnn, t);
                CmdD.CommandType = CommandType.StoredProcedure;
                foreach (DetalleFactura det in factura.lDetalle)
                {
                    //CmdD.Parameters.AddWithValue("@id_detalle_reserva", det.IdDetalleReserva); identity???
                    CmdD.Parameters.AddWithValue("@id_factura", IdFactura);
                    CmdD.Parameters.AddWithValue("@id_funcion", det.Funcion.IdFuncion);
                    CmdD.Parameters.AddWithValue("@cantidad", det.Cantidad);                   
                    CmdD.ExecuteNonQuery();
                }

                t.Commit();
                return true;
            }
            catch (Exception)
            {
                t.Rollback();
                return false;
            }
            finally
            {
                if (cnn.State.Equals(ConnectionState.Open))
                    cnn.Close();
            }
        }
    }
}
