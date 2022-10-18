using System;
class Programa {
  static void Main() {

    CuentaBancaria MiCuenta = new CuentaBancaria();
    
    Console.WriteLine(MiCuenta.ObtenerNombre());
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    MiCuenta.Deposito(1000);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    
    
    
    
   /* CuentaBancaria MiCuenta2 = new CuentaBancaria();
    MiCuenta.EstableceNombre("Juan");
    MiCuenta.Deposito(-1000);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    MiCuenta.Retiro(1300);
    Console.WriteLine(MiCuenta.ObtenerNombre());
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    
    MiCuenta2.Deposito(1234);
    Console.WriteLine(MiCuenta2.ObtenerSaldo());
    
    */
  }
}

class CuentaBancaria
{
  private decimal saldo;
  private string nombre;
  
  public CuentaBancaria(){
      saldo = 3000;
      nombre = "Desconocido";
  }
  public void Retiro(decimal cantidad){
    if (saldo >= cantidad)  
      saldo-=cantidad;
    else
      Console.WriteLine("Saldo insuficiente: {0:C}", saldo);
  }
  public void Deposito(decimal cantidad){
    if (saldo > 0 )
      saldo+=cantidad;
    else 
      Console.WriteLine("Error: cantidad debe ser superior a 0 (cero); ");
  }
  public decimal ObtenerSaldo( ){
    return saldo;
  }
  public void EstableceNombre(string nombre){
    this.nombre = nombre;
  }
  public string ObtenerNombre(){
    return this.nombre;
  }
}

  }
  public void EstableceNombre(string nombre){
    this.nombre = nombre;
  }
  public string ObtenerNombre(){
    return this.nombre;
  }
}