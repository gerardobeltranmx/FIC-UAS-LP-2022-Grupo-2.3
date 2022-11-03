using System;

class Estudiante {
    string nombre;
    int edad;
    int grado;

    public Estudiante (string nombre, int edad, int grado){
        this.nombre = nombre;
        this.edad = edad;
        this.grado = grado;
    }
    public string ObtenerNombre(){
        return nombre;
    }
    public int ObtenerEdad(){
        return edad;
    }
    public int ObtenerGrado(){
        return grado;
    }
}


class Program {
    static void Main(string[] args) {

        Lista <Estudiante> info = new Lista<Estudiante>(5);
        
       
       Estudiante est1 = new Estudiante("Hugo", 12, 2);
       Estudiante est2 = new Estudiante("Paco", 11, 1);
       Estudiante est3 = new Estudiante("Luis", 10, 3);
       
       info.Agregar(est1);
       info.Agregar(est2);
       info.Agregar(est3);
       
       
       
        for (int i=0; i < info.ULTIMO; i++){
            
            Estudiante est  = info.Obtener(i);
             
            Console.WriteLine(est.ObtenerNombre());
        }
        
        // Console.WriteLine(info.Buscar("Jocker"));
        
    }
    
}
 class Lista <T> {
    T [] Datos;
    
    int Ultimo=0, Tam=0;
    
    public int TAM{
        get {
            return Tam;
        }
    }
    
    public int ULTIMO{
        get {
            return Ultimo;
        }
    }
    

    public Lista (int N){
        Datos = new T[N];
        Tam = N;
    }
   
    public int Buscar (T Dato){
        int Enc=-1;
        for (int i=0; i<Tam && Enc==-1 ;i++ ){
            
            if (Dato.Equals(Datos[i])){
                Enc = i;
            }
        }
        return Enc;
    }
    
    public bool Agregar (T Dato){
        bool Estado = false;
        if (Ultimo < Tam){
            Datos[Ultimo]=Dato;
            Ultimo++;
            Estado = true;
        }
        return Estado;
    }

    public T Obtener  (int Pos){
     
        return Datos[Pos];    
        
    }

}


