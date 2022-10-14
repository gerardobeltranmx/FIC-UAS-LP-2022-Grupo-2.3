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