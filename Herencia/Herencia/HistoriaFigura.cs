using System;
    
namespace Herencia
{
    /// <summary>
    /// Descripción de resumen para HistoriaFigura.
    /// </summary>
    public class HistoriaFigura : Persona
    {
        //Aviso que no hay (String nombre) ctor;

        public HistoriaFigura(string Name, DateTime Birthdate) : base(Name, Birthdate) {
		}

        public HistoriaFigura(string Name, DateTime Birthdate, DateTime DeathDate) : base(Name, Birthdate) 
        {
            //Nombre y Fecha de Nacimiento se establecerán en la base ctor
            base.DeathDate = DeathDate;
        }

        public override string Name
        {
            get { return string.Format("Historia Figura \"{0}\"", base.Name); }
            set { base.Name = value; }
        }


        /// <summary>
        /// Modificaciones de base de Edad
        /// </summary>
        /// <returns></returns>
        public override string HowOld()
        {
            if(DeathDate == DateTime.MinValue)
                return base.HowOld();
            else
                return string.Format("{0} muerto {1}, a los {2} años.",
				                     Name,DeathDate.ToShortDateString(),YearsOld);
        }

    }
}
