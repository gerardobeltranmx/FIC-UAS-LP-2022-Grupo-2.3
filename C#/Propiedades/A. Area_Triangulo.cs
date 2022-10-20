using System;
class Programa {
  static void Main() {
     Triangulo Piramide = new Triangulo();
     Piramide.PBase = double.Parse(Console.ReadLine());
    Piramide.PAltura = double.Parse(Console.ReadLine());
    /* Console.WriteLine("Con base de {0} y altura de {1} tenemos una         area de  {2}",
        Piramide.PBase,
        Piramide.PAltura,
        Piramide.PArea 
      );*/
    Console.WriteLine("{0:F3}", Piramide.PArea );
  }
}


class Triangulo {
  private double Base, Altura;


  public double PBase{
    set {
        Base = value;
    }
    get {
      return Base;
    }
  } 
  public double PAltura {
    set {
      Altura = value;
    }
    get {
      return Altura;
    }
  }
  public double PArea{
    return ObtenerArea();
  }
    private double ObtenerArea(){
    return Base * Altura;
  }
  
}