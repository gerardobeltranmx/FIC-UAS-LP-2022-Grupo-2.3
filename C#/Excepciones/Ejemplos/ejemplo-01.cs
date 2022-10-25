using System;
class Programa {
  static void Main() {
    
    Console.Write("Escriba un número: ");
	
	try{
	    int i = int.Parse(Console.ReadLine());
	    Console.WriteLine("El numero es {0} ", i);
	    int dato = 10 / i;
	    Console.WriteLine("dato es {0} ", dato);
	    
	}
	catch (OverflowException ){
	    //Console.WriteLine("Error: " + Error.Message);
        Console.WriteLine("Error: El numero es muy grande, tus limite son: {0} hasta {1}",
            Int32.MinValue,
            Int32.MaxValue
        );
	}
	catch(FormatException ){
	    // Console.WriteLine("Error: " + Error.Message);
	    Console.WriteLine("Error: Debe escribir solo numeros,intente de nuevo");
	}
	catch(DivideByZeroException){
	    Console.WriteLine("Se presento una división por cero(0)");
	}
	catch (Exception Error){
	    Console.WriteLine("Error:" + Error.Message);
	}
  }
}