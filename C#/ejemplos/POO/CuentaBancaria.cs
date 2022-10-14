using System;
class Programa {
  static void Main() {

    CuentaBancaria MiCuenta = new CuentaBancaria();
    
    MiCuenta.Deposito(1000);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    MiCuenta.Retiro(300);
    Console.WriteLine(MiCuenta.ObtenerSaldo());
    
    
    
  }
}

class CuentaBancaria
{
  private decimal saldo;
  private string nombre;
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