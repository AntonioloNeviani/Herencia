using System;
    
namespace Herencia
{
    /// <summary>
    /// Descripción de resumen para Persona.
    /// </summary>
    public class Persona
    {
        public Persona(string Name) : this(Name, DateTime.Now) {
		}

        public Persona(string Name, DateTime Birthdate)
        {
           _Name = Name;
            _Birthdate = Birthdate;
        }

        private string _Name;
        public virtual string Name
        {
            get {    return _Name; }
            set { _Name = value; }
        }

        private DateTime _Birthdate;
        public DateTime Birthdate
        {
            get {    return _Birthdate; }
            set { _Birthdate = value; }
        }

        private DateTime _DeathDate;
        public DateTime DeathDate
        {
            get {    return _DeathDate; }
            set { _DeathDate = value; }
        }

        /// <summary>
        /// Calcular Años. No estoy seguro si este es el mejor método de cálculo, 
        /// pero funciona.
        /// </summary>
        /// <summary>
        /// Calcular Duración de la vida
        /// </summary>
        public int YearsOld
        {
            get
            {
                TimeSpan alive;
                if(DeathDate == DateTime.MinValue)
                    alive = new TimeSpan(DateTime.Now.Ticks - Birthdate.Ticks);
                else
                    alive = new TimeSpan(DeathDate.Ticks - Birthdate.Ticks);
                return (int)alive.TotalDays/365;
            }
        }

        /// <summary>
        /// Método auxiliar para escribir la edad de la persona, que los medios virtuales
        /// Este método está aquí para allá todos los objetos que heredan de una persona, A MENOS
        /// Es sobreescrito en la clase concreate (Ver HistoriaFigura)
        /// </summary>
        /// <returns></returns>
        public virtual string HowOld()
        {
            return string.Format("{0} tiene {1} años de edad.",Name,YearsOld);
        }
    }
}