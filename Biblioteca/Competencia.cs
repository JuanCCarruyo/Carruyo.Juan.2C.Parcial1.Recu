using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        #region Atributos
        private int cantidaCompetidores;
        private List<Equipo> equipos;
        private string nombre;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado que asignara por defecto 5 a cantidad de competidores
        /// </summary>
        /// <param name="nombre"></param>
        private Competencia(string nombre)
        {
            this.cantidaCompetidores = 5;
        }
        /// <summary>
        /// Constructor publico que instancia la lista, asigna un nombre, inicializa la cantidad de competidores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidadCompetidores"></param>
        public Competencia(string nombre, int cantidadCompetidores) 
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidaCompetidores = cantidadCompetidores;
        }
        #endregion


        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int CantidaCompetidores
        {
            get { return this.cantidaCompetidores; }
            set { this.cantidaCompetidores = value; }
        }
        public List<Equipo> Equipos
        {
            get { return this.equipos; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega un equipo a la competencia si no se encuentra en ella y aun dispone de capacidad
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns>Competencia con el equipo nuevo agregado y ya no esta y dispone de capacidad</returns>
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {

            if (torneo.cantidaCompetidores > 0 && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                torneo.cantidaCompetidores--;
            }

            return torneo;
        }
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre de Competencia: - {torneo.Nombre}\n");
            sb.AppendFormat($"Cantidad de Competidores: - {torneo.CantidaCompetidores}\n");
            sb.AppendFormat($"Competidores:\n---------------------------------\n");
            foreach (Equipo e in torneo.equipos)
                sb.AppendFormat($"{e.ToString()}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Una competencia y un equipo seran iguales si el equipo ya se encuentra dentro de la competencia
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns>verdadero si el equipo se encuentra en la competencia, falso sino</returns>
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            bool auxReturn = false;

            foreach (Equipo e in torneo.equipos)
            {
                if (e == equipo)
                {
                    auxReturn = true;
                    break;
                }
            }

            return auxReturn;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }


        #endregion
    }
}
