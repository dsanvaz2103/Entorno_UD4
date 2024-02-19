using System;
class ArrayExample
{
    //En el bucle for dela función Main ,establezca un punto deinterrupción haciendo clicen el margen izquierdo dela línea decódigo siguiente:
    static void Main()
    {
        //Creamos un array de caracter char de longitud 10 
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        //Declaramos "name" de tipo String
        string name = "";
        //Declarar la variable "a" de longitud 10
        int[] a = new int[10];
        //Con el for recorreremos el array utilizando el procedimiento dentro del parentesis y leyendo su longitud con el .lengt
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }

   
    static void SendMessage(string name, int msg)
    {
        //Dentro de la función, se utiliza Console.WriteLine para imprimir un mensaje en la consola.Se construye concatenando las partes estáticas del mensaje con los valores de las variables name y msg.
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
