/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
       
       int numero1 , multiplicacão;
            Console.WriteLine("Entre com o primeiro lado:");
            numero1= int.Parse(Console.ReadLine());
            multiplicacão=numero1 * numero1;
            Console.WriteLine("Valores entrados: {0}e{1}", numero1 , numero1);
            Console.WriteLine("multiplicação = {0}", multiplicacão);
            Console.ReadLine();
   }
}