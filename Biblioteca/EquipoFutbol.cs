using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        #region Constructores
        /// <summary>
        /// Su constructor por defecto no poseera jugadores estrella
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoFutbol(string nombre) : base(nombre)
        {
            this.jugadoresEstrellas = false;
        }
        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : this(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna un valor entre 7 y 10, si posee jugadores estrella se duplica el valor
        /// </summary>
        /// <returns>Retorna un valor entre 7 y 10, si posee jugadores estrella se duplica el valor</returns>
        public override int GetDificultad()
        {
            Random r = new Random();
            int retornoDificultad;
            retornoDificultad = r.Next(7, 10);
            if (this.jugadoresEstrellas)
                retornoDificultad *= 2;

            return retornoDificultad;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Futbol - {base.MostrarDatos()}");

            return sb.ToString();
        }
        /// <summary>
        /// Hace publico el metodo mostrar datos
        /// </summary>
        /// <returns>metodo mostrar datos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
