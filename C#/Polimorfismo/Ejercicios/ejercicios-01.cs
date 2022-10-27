using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
  }
  
  class figura
{
    public virtual Double Area( )  
    { 
	return 0;
    }
    public virtual Double Perimetro( ) 
    { 
	return 0;
    } 
}

class cuadrado : figura {
        double lado;

        public cuadrado(double lado) {
            this.lado = lado;
        }
        public override double Area(){
            return lado * lado;
        }
        public override double Perimetro()
        {
            return 4 * lado;
        }
 }
class circulo : figura{
        double radio;

        public circulo(double radio)
        {
            this.radio = radio;
        }
        public override double Area ()
        {
            return 3.1416*radio*radio;
        }
        public override double Perimetro()
        {
            return 2*3.1416*radio ;
        }
  }
class triangulo : figura(){
    private Base, Altura;
    public triangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override double Area ()
        {
            return Base * Altura;
        }
        public override double Perimetro()
        {
            return 0 ;
        }
        
}
class rectangulo : figura(){
    private double Lado1, Lado2;
     public rectangulo(double Lado1, double Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }+
        public override double Area ()
        {
            return Lado1 * Lado2;
        }
        public override double Perimetro()
        {
            return  2*Lado1 + 2*Lado2  ;
        }
}

  
}
