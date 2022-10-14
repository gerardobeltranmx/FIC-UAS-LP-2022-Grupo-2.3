using System;
class Programa {
  static void Main() {

    CuentaBancaria MiCuenta = new CuentaBancaria();
    CuentaBancaria MiCuenta2 = new CuentaBancaria();
    MiCuenta.nombre = "Juan";
    MiCuenta.Deposito(1000);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    MiCuenta.Retiro(300);
    Console.WriteLine(MiCuenta.nombre);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    
    MiCuenta2.Deposito(1234);
    Console.WriteLine(MiCuenta2.ObtenerSaldo());
    
    
  }
}

class CuentaBancaria
{
  private decimal saldo;
  public string nombre;
  public void Retiro(decimal cantidad){
    saldo-=cantidad;
  }
  public void Deposito(decimal cantidad){
    saldo+=cantidad;
  }
  public decimal ObtenerSaldo( ){
    return saldo;
  }
}