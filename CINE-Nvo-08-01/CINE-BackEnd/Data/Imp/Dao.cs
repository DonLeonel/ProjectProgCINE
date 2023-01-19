using CINE_BackEnd.Data.Interfaz;
using CINE_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Data.Imp
{
    internal class Dao : IDAO
    {
        public bool InsertPeliculas(Pelicula pelicula)
        {
           return HelperSing.Instance.InsertPeliculas("SP_INSERT_PELICULA",pelicula);
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lClient = new List<Cliente>();
            DataTable dt = HelperSing.Instance.ConsultarDB("SP_GET_CLIENTES");
            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();
                c.IdCliente = (int)dr[0];
                c.Nombre = (string)dr[1];
                c.Apellido = (string)dr[2];
                c.FechaNac = (DateTime)dr[3];
                lClient.Add(c);
            }
            return lClient;
        }

        public List<Funcion> GetFunciones()
        {
            List<Funcion> lFuncion = new List<Funcion>();
            DataTable dt = HelperSing.Instance.ConsultarDB("SP_GET_FUNCIONES");
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();
                p.Titulo = (string)dr[4];

                Sala s = new Sala();
                s.IdSala = (int)dr[5];
                s.Tipo = (string)dr[6];

                Funcion f = new Funcion();
                f.IdFuncion = (int)dr[0];
                f.Fecha = (DateTime)dr[1];
                f.HoraInicio = (DateTime)dr[2];
                f.Precio = (double)dr[3];
                f.Pelicula = p;
                f.Sala = s;
                f.Agotado = (bool)dr[7];

                lFuncion.Add(f);
            }
            return lFuncion;
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPeli = new List<Pelicula>();
            DataTable dt = HelperSing.Instance.ConsultarDB("SP_GET_PELICULAS");
            foreach (DataRow dr in dt.Rows)
            {
                Calificacion c = new Calificacion();
                c.Descripcion = (string)dr[6];

                Genero g = new Genero();
                g.Descripcion = (string)dr[10];

                Origen o = new Origen();
                o.Descripcion = (string)dr[11];
                
                Pelicula p = new Pelicula();
                p.Id_pelicula = (int)dr[0];
                p.Titulo = (string)dr[1];
                p.Sinopsis = (string)dr[2];
                p.FechaEstreno = (DateTime)dr[3];
                p.Elenco = (string)dr[4];
                //p.Duracion = (float)dr[5];
                p.Calificacion = c; //6
                p.AptoTodoPublico = Convert.ToInt32(dr[7]);
                p.Idioma = (string)dr[8];
                p.Subtitulo = Convert.ToInt32(dr[9]);
                p.Genero = g; //10
                p.Origen = o; //11
                lPeli.Add(p);                
            }
            return lPeli;
        }

        public List<Reserva> GetReservas()
        {
            throw new NotImplementedException();
        }

        public List<Reserva> GetReservaXFecha(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public bool InsertCliente(Cliente cliente)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nombre", cliente.Nombre));
            lst.Add(new Parametro("@apellido", cliente.Apellido));
            lst.Add(new Parametro("@fec_nac", cliente.FechaNac));

            return HelperSing.Instance.InsertDB("SP_INSERT_CLIENTE", lst);
        }

        public bool InsertFactura(Factura factura)
        {
            return HelperSing.Instance.InsertFactura("SP_INSERT_FACTURA","SP_INSERT_DET_FACTURA",factura);

        }

        public bool InsertFuncion(Funcion funcion)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha", funcion.Fecha));
            lst.Add(new Parametro("@hora_inicio", funcion.HoraInicio));
            lst.Add(new Parametro("@precio", funcion.Precio));
            lst.Add(new Parametro("@id_pelicula", funcion.Pelicula.Id_pelicula));
            lst.Add(new Parametro("@id_sala", funcion.Sala.IdSala));
            
            return HelperSing.Instance.InsertDB("SP_INSERT_FUNCION", lst);
        }

        public bool InsertReserva(Reserva reserva)
        {
            return HelperSing.Instance.InsertReserva("SP_INSERT_RESERVA", "SP_INSERT_DET_RESERVA", reserva);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_cliente", cliente.IdCliente));
            lst.Add(new Parametro("@nombre", cliente.Nombre));
            lst.Add(new Parametro("@apellido", cliente.Apellido));
            lst.Add(new Parametro("@fec_nac", cliente.FechaNac));

            return HelperSing.Instance.InsertDB("SP_UPDATE_CLIENTE", lst);
        }

        public DataTable Get(string sp)
        {
            return HelperSing.Instance.ConsultarDB(sp);
        }
    }
}
