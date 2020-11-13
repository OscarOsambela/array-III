using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    //2. creamos el array
    int [] numeros = new int[7];
    numeros[0] = 1;
    numeros[1] = 2;
    numeros[2] = 3;
    numeros[3] = 4;
    numeros[4] = 5;
    numeros[5] = 6;
    numeros[6] = 7;
    //3.instanciamos el metodo
    ProcesaDatos(numeros);
    //4.recorremos el array con el foreach
    foreach(int i in numeros){
      Console.WriteLine(i);
    }
  }
  //1.creamos el metodo que sumara 10 a cada valor; no se puede manipular los valores con el foreach solo lo permite el for
  public static void ProcesaDatos(int [] datos){
    for(int i=0; i<datos.Length; i++){
      datos[i] += 10;
    }
  }
}
