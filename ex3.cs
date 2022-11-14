/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
  
   int lado1 , lado2, area, perimetro;
            Console.WriteLine("Entre com o primeiro lado:");
            lado1= int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo lado:");
            lado2 = int.Parse(Console.ReadLine());
            area=lado1 * lado2;
            perimetro= (2* lado1) + (2* lado2);
            Console.WriteLine("Valores entrados: {0}e{1}", lado1 , lado2);
            Console.WriteLine("Valor da area = {0}", area);
            Console.WriteLine("Perimetro = {0}", perimetro);
            Console.WriteLine("Fim de Programa....");
            Console.ReadLine();
   }
}