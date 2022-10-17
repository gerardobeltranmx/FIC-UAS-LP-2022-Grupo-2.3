using System;
class Programa {
  static void Main() {

    

  
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