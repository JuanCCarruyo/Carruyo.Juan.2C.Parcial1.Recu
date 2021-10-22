using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoBasket : Equipo
    {
        private Eliga liga;

        #region Constructores
        /// <summary>
        /// Su constructor por defecto setea liga como NBA
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoBasket(string nombre):base(nombre)
        {
            this.liga = Eliga.NBA;
        }
        public EquipoBasket(string nombre, Eliga liga):this(nombre)
        {
            this.liga = liga;
        }
        #endregion

        /// <summary>
        /// Retorna un valor entre 8 y 10 si es NBA, 5 y 10 si es EuroLeague y 1 y 7 si es ACB
        /// </summary>
        /// <returns>Retorna un valor entre 8 y 10 si es NBA, 5 y 10 si es EuroLeague y 1 y 7 si es ACB</returns>
        public override int GetDificultad()
        {
            Random r = new Random();
            int retornoDificultad = 0;
            switch (this.liga)
            {
                case Eliga.NBA:
                    retornoDificultad = r.Next(8, 10);
                    break;

                case Eliga.Euroleague:
                    retornoDificultad = r.Next(5, 10);
                    break;

                case Eliga.ACB:
                    retornoDificultad = r.Next(1, 7);
                    break;

            }

            return retornoDificultad;
        }


        /// <summary>
        /// Llama al metodo base y agrega "Basket -" antes del nombre del equipo
        /// </summary>
        /// <returns>"Basket -" con el nombre del equipo</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Basket - {base.MostrarDatos()}");

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

    }

    public enum Eliga
    {
        NBA,
        Euroleague,
        ACB
    }
}
