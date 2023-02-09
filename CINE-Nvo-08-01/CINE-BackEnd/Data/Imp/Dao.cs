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
                c.Calle = (string)dr[4];
                c.Altura = (int)dr[5];
                c.Telefono = (string)dr[6];
                c.Mail = (string)dr[7];
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
                p.Id_pelicula = (int)dr[1];
                p.Titulo = (string)dr[6];

                Sala s = new Sala();
                s.IdSala = (int)dr[2];
                s.Tipo = (string)dr[7];

                Funcion f = new Funcion();
                f.IdFuncion = (int)dr[0];
                f.Fecha = (DateTime)dr[3];
                f.HoraInicio = (DateTime)dr[4];
                f.Precio = (double)dr[5];
                f.Pelicula = p;
                f.Sala = s;
                f.Agotado = (bool)dr[8];

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
            List<Reserva> lst = new List<Reserva>();
            var dt = HelperSing.Instance.ConsultarDB("SP_GET_RESERVAS");
            foreach (DataRow dr in dt.Rows)
            {
                Cliente cli = new Cliente();
                cli.IdCliente = (int)dr[1];
                cli.Nombre = (string)dr[2];
                cli.Apellido = (string)dr[3];

                Reserva reserva = new Reserva();
                reserva.Id_reserva = (int)dr[0];
                reserva.FechaReserva = (DateTime)dr[4];
                reserva.Cliente = cli;

                lst.Add(reserva);
            }
            return lst;
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
            lst.Add(new Parametro("@calle", cliente.Calle));
            lst.Add(new Parametro("@altura", cliente.Altura));
            lst.Add(new Parametro("@telefono", cliente.Telefono));
            lst.Add(new Parametro("@mail", cliente.Mail));

            return HelperSing.Instance.ActualizarDB("SP_INSERT_CLIENTE", lst);
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
            lst.Add(new Parametro("@id_peli", funcion.Pelicula.Id_pelicula));
            lst.Add(new Parametro("@id_sala", funcion.Sala.IdSala));
            
            return HelperSing.Instance.ActualizarDB("SP_INSERT_FUNCION", lst);
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
            lst.Add(new Parametro("@calle", cliente.Calle));
            lst.Add(new Parametro("@altura", cliente.Altura));
            lst.Add(new Parametro("@telefono", cliente.Telefono));
            lst.Add(new Parametro("@mail", cliente.Mail));

            return HelperSing.Instance.ActualizarDB("SP_UPDATE_CLIENTE", lst);
        }

        public DataTable Get(string sp)
        {
            return HelperSing.Instance.ConsultarDB(sp);
        }

        public bool UpdatePelicula(Pelicula peli)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_pelicula", peli.Id_pelicula));
            lst.Add(new Parametro("@titulo", peli.Titulo));
            lst.Add(new Parametro("@sinopsis", peli.Sinopsis));
            lst.Add(new Parametro("@fec_estreno", peli.FechaEstreno));
            lst.Add(new Parametro("@elenco", peli.Elenco));
            lst.Add(new Parametro("@duracion", peli.Duracion));
            lst.Add(new Parametro("@calificacion", peli.Calificacion.IdCalif));
            lst.Add(new Parametro("@apta_todo_publico", peli.AptoTodoPublico));
            lst.Add(new Parametro("@idioma", peli.Idioma));
            lst.Add(new Parametro("@subtitulo", peli.Subtitulo));
            lst.Add(new Parametro("@origen", peli.Origen.IdOrigen));
            lst.Add(new Parametro("@genero", peli.Genero.Id_genero));

            return HelperSing.Instance.ActualizarDB("SP_UPDATE_PELICULA", lst);
        }

        public bool DeletePelicula(int Id)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_pelicula", Id));

            return HelperSing.Instance.ActualizarDB("SP_DELETE_PELICULA", lst);
        }

        public bool UpdateFuncion(Funcion funcion)
        {           
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_funcion", funcion.IdFuncion));
            lst.Add(new Parametro("@fecha", funcion.Fecha));
            lst.Add(new Parametro("@hora_inicio", funcion.HoraInicio));
            lst.Add(new Parametro("@precio", funcion.Precio));
            lst.Add(new Parametro("@id_peli", funcion.Pelicula.Id_pelicula));
            lst.Add(new Parametro("@id_sala", funcion.Sala.IdSala));

            return HelperSing.Instance.ActualizarDB("SP_UPDATE_FUNCION", lst);
        }

        public List<Funcion> GetFuncionXNombre(string NomFunc)
        {
            
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nombre", NomFunc));

            List<Funcion> lfunc = new List<Funcion>();
            DataTable dt = HelperSing.Instance.ConsultarDBP("SP_GET_FUNCION_X_NOMBRE", lst);
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();
                p.Id_pelicula = (int)dr[1];
                p.Titulo = (string)dr[6];              

                Sala s = new Sala();
                s.IdSala = (int)dr[2];
                s.Tipo = (string)dr[7];

                Funcion f = new Funcion();
                f.IdFuncion = (int)dr[0];
                f.Fecha = (DateTime)dr[3];
                f.HoraInicio = (DateTime)dr[4];
                f.Precio = (double)dr[5];
                f.Pelicula = p;
                f.Sala = s;
                f.Agotado = (bool)dr[8];

                lfunc.Add(f);
            }
            return lfunc;
        }

        public List<Funcion> GetFuncionReserva()
        {
            List<Funcion> lfunc = new List<Funcion>();
            DataTable dt = HelperSing.Instance.ConsultarDB("SP_GET_FUNCION_RESERVA");
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();
                p.Id_pelicula = (int)dr[1];
                p.Titulo = (string)dr[6];
                
                Sala s = new Sala();
                s.IdSala = (int)dr[2];
                s.Tipo = (string)dr[7];

                Funcion f = new Funcion();
                f.IdFuncion = (int)dr[0];
                f.Fecha = (DateTime)dr[3];
                f.HoraInicio = (DateTime)dr[4];
                f.Precio = (double)dr[5];
                f.Pelicula = p;
                f.Sala = s;
                f.Agotado = (bool)dr[8];

                lfunc.Add(f);
            }
            return lfunc;
        }

        public List<DetalleReserva> GetDetalleReservas(int IdReser)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_reserva", IdReser));

            var dt = HelperSing.Instance.ConsultarDBP("SP_GET_DETALLE_RESERVA",lst);
            List<DetalleReserva> lstD = new List<DetalleReserva>();
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();
                p.Titulo = (string)dr[0];

                Sala s = new Sala();
                s.IdSala = (int)dr[4];
                s.Tipo = (string)dr[5];

                Funcion f = new Funcion();
                f.Fecha = (DateTime)dr[1];
                f.HoraInicio = (DateTime)dr[2];
                f.Precio = (double)dr[3];
                f.Pelicula = p;
                f.Sala = s;

                DetalleReserva det = new DetalleReserva();
                det.Funcion = f; 
                
                lstD.Add(det);
            }
            return lstD;
        }
    }
}
