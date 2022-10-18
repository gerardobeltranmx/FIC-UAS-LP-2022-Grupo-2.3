using System;
class Programa {
  static void Main() {
    int Temp = int.Parse(Console.ReadLine());

    Temperaturas Clima = new Temperaturas(Temp);
      Console.WriteLine ( "{0} {1} {2}",
      Clima.GradosKelvin(),
      Clima.GradosFahrenheit(),
      Clima.GradosRéaumur()
    );
    
  }
}

class  Temperaturas {
  private int GradosCelcius;

  public Temperaturas(){
    
  }
  public Temperaturas(int Temp){
    GradosCelcius = Temp;
  }
  
  
  public void CambiarTemp(int Temp){
    GradosCelcius = Temp;
  }

  public int ObtenerTemp(){
    return 9 / 5 * GradosCelcius + 32;
  }

  public int GradosFahrenheit(){
    return 9 / 5 * GradosCelcius + 32;
  }

  public int GradosKelvin(){
    return GradosCelcius + 273;
  }

  public int GradosRéaumur(){
    return (4/5) * GradosCelcius;
  }

  
  
}
