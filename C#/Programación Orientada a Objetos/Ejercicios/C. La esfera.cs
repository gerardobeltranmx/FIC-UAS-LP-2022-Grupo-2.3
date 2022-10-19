using System;
class Programa {
  static void Main() {
    Esfera Figura = new Figura();
    double Radio;
    Radio = double.Parse(Console.ReadLine());
    Figura.CambiarRadio(Radio);
    Console.WriteLine("Volumen:{0:F2} Superficie:{1:F2}",
                Figura.Volumen(),
                Figura.Superficie()
              );
  }
}
class Esfera{
  private double Radio;
  private const double PI=3.1416;
  public Esfera (){
    Radio = 0; 
  }
  public Esfera (double Radio){
    this.Radio = Radio;
  }
  public double ObtenerRadio(){
    return Radio;
  }
  public void CambiarRadio(double Radio){
    this.Radio = Radio;
  }
  public double Superficie(){
     return 4 * PI * Math.Pow(Radio,2);   
  }
  public double Volumen(){
     return 4.0/3.0 * PI * Math.Pow(Radio,3);   
  }
}  