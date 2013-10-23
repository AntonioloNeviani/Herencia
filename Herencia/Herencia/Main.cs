using System;
     
 namespace Herencia
 {
     /// <Resumen>
     ///  Descripción breve del principal.
     /// </Resumen>
     public class TestHerencia
     {
        private TestHerencia() {}
        public static void Main(string[] args)
        {
            Persona p = new Persona("Cameron Cate");
            Console.WriteLine(p.HowOld());

            p = new Persona("Scott Cate", new DateTime(1973,6,24));
            Console.WriteLine(p.HowOld());

            HistoriaFigura h = new HistoriaFigura("Thomas Jefferson", 
			                                      new DateTime(1743,4,13), new DateTime(1826,7,4));
            Console.WriteLine(h.HowOld());

            h = new HistoriaFigura("Presidente Bill Clinton", new DateTime(1946,8,19));
            Console.WriteLine(h.HowOld());

            Console.Read();
        }
    }
} 