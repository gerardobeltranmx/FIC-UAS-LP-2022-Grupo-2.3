using System;
class Programa {
  static void Main() {
    Circulo Obj;
    Obj = new Circulo();
    double radio;
    radio = double.Parse(Console.ReadLine());
    Obj.CambiarRadio(radio);
    Console.WriteLine("{0:F2}",Obj.Area()); 
  }
}
class Circulo {
  private double radio;
  public double Area(){
    return Math.PI * Math.Pow(this.radio, 2);
  }
  public void CambiarRadio(double radio){
      this.radio = radio;
  }
  public double ObtenerRadio(){
    return this.radio;
  }
}