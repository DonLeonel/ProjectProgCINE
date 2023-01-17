using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Pelicula
    {
        public int Id_pelicula { get; set; }  //Identity
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Elenco { get; set; }
        public decimal Duracion { get; set; }
        public Calificacion Calificacion { get; set; }
        public bool AptoTodoPublico { get; set; }
        public string Idioma { get; set; }       
        public bool Subtitulo { get; set; }
        public Origen Origen { get; set; }
        public Genero Genero { get; set; }

        public Pelicula(int id_pelicula, string titulo, string sinopsis, DateTime fecha_estreno, string elenco, decimal duracion, Calificacion calificacion, bool apto_todo_publico, string idioma, bool subtitulo, Origen origen, Genero genero)
        {
            Id_pelicula = id_pelicula;
            Titulo = titulo;
            Sinopsis = sinopsis;
            FechaEstreno = fecha_estreno;
            Elenco = elenco;
            Duracion = duracion;
            Calificacion = calificacion;
            AptoTodoPublico = apto_todo_publico;
            Idioma = idioma;
            Subtitulo = subtitulo;
            Origen = origen;
            Genero = genero;
        }

        public Pelicula()
        {

        }
    }
}
