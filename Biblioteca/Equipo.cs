using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Equipo
    {
        #region Atributos
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;
        #endregion

        #region Constructores
        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        public string Nombre { get { return this.nombre; } }
        public string Tipo { get { return this.nombre; } }

        public int PE
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados = value; }
        }
        public int PG
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }
        public int PJ
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int PP
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }
        public int Puntuacion
        {
            get { return this.puntuacion; }
            set { this.puntuacion = value; }
        }
        #endregion

        /// <summary>
        /// Sobrescritura del Metodo "Equals", retorna verdadero si ambos objectos son del mismo tipo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si ambos objetos son del tipo TYPE</returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
                return true;

            return false;
        }

        /// <summary>
        /// Sobrecarga booleana del operador ==
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns>retornara True si los nombres y el Type del equipo son iguales</returns>
        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            bool auxReturn = false;
            if (equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB))
                auxReturn = true;

            return auxReturn;
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

        #region Metodos
        /// <summary>
        /// Metodo protegido que retorna nombre del equipo
        /// </summary>
        /// <returns>nombre del equipo</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.nombre}");

            return sb.ToString();
        }

        public abstract int GetDificultad();
       
        /// <summary>
        /// Simula un partido si ambos equipos son del mismo tipo, el ganador sumara 3 puntos y si empata ambos suman 1
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns></returns>
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool auxRetorno = false;

            if (equipoA.Equals(equipoB))
            {
                auxRetorno = true;

                if (equipoA.GetDificultad() == equipoB.GetDificultad())
                {
                    equipoA.puntuacion++;
                    equipoB.puntuacion++;
                }
                else if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.puntuacion += 3;
                    equipoA.PG++;
                    equipoB.PP++;
                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.puntuacion += 3;
                    equipoB.PG++;
                    equipoA.PP++;
                }

                equipoA.PJ++;
                equipoB.PJ++;
            }
                


            return auxRetorno;
        }
        #endregion

    }
}
