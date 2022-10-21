using System;
class Programa {
  static void Main() {

    Cilindro Tanque = new  Cilindro(10,100);

    //Tanque.CambiarRadio(10);
    //Tanque.CambiarAltura(100);
    Console.WriteLine("Radio: {0} Altura: {1} Volumen: {2} Area de la base: {3} Perimetro: {4}",
                        Tanque.ObtenerRadio(),
                        Tanque.ObtenerAltura(),
                        Tanque.ObtenerVolumen(),
                        Tanque.ObtenerArea(),
                        Tanque.ObtenerPerimetro()
                    );  

  }
}
class Circulo{
  private double radio;
  public Circulo(){
    
  }
  public Circulo(double r){
    radio=r;
  }
  public void CambiarRadio(double r){
    radio=r;
  }
  public double ObtenerRadio(){
    return radio;
  }
  public double ObtenerArea(){
    return 3.1416*radio*radio;
  }
  public double ObtenerPerimetro(){
    return 3.1416*2*radio;
  }
}

class Cilindro:Circulo{
  private double altura;
  public Cilindro (){
    
  }
  public Cilindro(double r, double h): base(r){
    altura=h;
  }
  public void CambiarAltura(double h){
    altura=h;
  }
  public double ObtenerAltura(){
    return altura;
  }
  public double ObtenerVolumen(){
    return ObtenerArea()*ObtenerAltura();
  }
  public double ObtenerSuperfice(){
      return 2 * ObtenerArea() + ObtenerPerimetro() * ObtenerAltura(); 
  }
}