using System;
class Programa {
  static void Main() {
    Temperaturas Clima = new Temperaturas();
    Clima.CambiarTemp (100);
    Console.WriteLine ( "{0} {1} {2}"
      Clima.GradosFahrenheit(),
      Clima.GradosKelvin(),
      Clima.GradosRéaumur()
    );
    
  }
}

class  Temperaturas {
  private int GradosCelcius;

  public Temperaturas(int Temp){
    GradosCelcius = Temp;
  }
  
  public CambiarTemp(int Temp){
    GradosCelcius = Temp;
  }

  public int ObtenerTemp(){
    return 1.8 * GradosCelcius + 32
  }

  public int GradosFahrenheit(){
    return 1.8 * GradosCelcius + 32
  }

  public int GradosKelvin(){
    return GradosCelcius + 273
  }

  public int GradosRéaumur(){
    return (4/5) * GradosCelcius
  }

  
  
}
