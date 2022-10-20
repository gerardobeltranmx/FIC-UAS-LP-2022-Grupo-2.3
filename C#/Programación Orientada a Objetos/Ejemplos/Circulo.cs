using System;
class Programa {
  static void Main() {
    
    Circulo llanta = new Circulo();
    
    llanta.Radio = 212;
    llanta.Area = 20;
    Console.WriteLine("Para un radio de {0} tenemos una area de {1}",
                llanta.Radio, 
                llanta.Area
    );
    
  }
}

class Circulo {

        private double radio;

        // Propiedad Radio
        public double Radio
        {
            set {
                if (value > 0)
                    radio = value;
                else
                  radio = 0;
            }
            get {
                return radio;
            }
        }
        // Propiedad Area
        public double Area
        {
            get {
                return ObtenerArea();
            }
        }

        private double ObtenerArea(){
            return Math.PI * Math.Pow(radio, 2);
        }
    
    
}