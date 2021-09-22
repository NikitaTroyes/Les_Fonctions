using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Fonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boucleConitnue = true; 
            while (boucleConitnue)
            { 
                // Addition 
                Console.WriteLine("entrer le premier nombre a : ");
                float premierN = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le second nombre b : ");
                float secondN = float.Parse(Console.ReadLine());
                Console.WriteLine("En additionant les deux nombres, on obtient : ");
                Console.WriteLine(premierN + "+" + secondN + "= " + Add(premierN, secondN));
                Console.ReadLine();

                // Soustraction
                Console.WriteLine("entrer le premier nombre a : ");
                float soustactionA = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le second nombre b : ");
                float soustractionB = float.Parse(Console.ReadLine());
                Console.WriteLine("En soustrayant les deux nombres, on obtient : ");
                Console.WriteLine(soustactionA + "-" + soustractionB + "= " + Substract(soustactionA, soustractionB));
                Console.ReadLine();

                // Multiplication
                Console.WriteLine("entrer le premier nombre a : ");
                float multiplicationA = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le second nombre b : ");
                float multiplicationB = float.Parse(Console.ReadLine());
                Console.WriteLine("En multipliant les deux nombres, on obtient : ");
                Console.WriteLine(multiplicationA + "*" + multiplicationB + "= " + Multiply(multiplicationA, multiplicationB));
                Console.ReadLine();

                // Division 
                Console.WriteLine("entrer le premier nombre a : ");
                float divisionA = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le second nombre b : ");
                float divisionB = float.Parse(Console.ReadLine());
                Console.WriteLine("En divisant les deux nombres, on obtient : ");
                Console.WriteLine(multiplicationA + "*" + multiplicationB + "= " + Divide(divisionA, divisionB));
                Console.ReadLine();

                // Modulo 
                Console.WriteLine("entrer le premier nombre a : ");
                int moduloA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("entrer le second nombre b : ");
                int moduloB = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Avec la fonction Modulo, on peut trouver le reste de la division euclidienne de a par b ");
                Console.WriteLine(moduloA + "%" + moduloB + "= " + Modulo(moduloA, moduloB));
                Console.ReadLine();
                

              }


            }
            
            
        // Add
            static float Add(float a, float b)
        {
            return a + b;
        }

        // Subtract
        static float Substract(float c, float d)
        {
            return c - d;
        }

        // Multiply
        static float Multiply(float e, float f)
        {
            return e * f;
        }

        // Divide
        static float Divide(float g, float h)
        {
            return g / h;
        }

        // Modulo 
        static int Modulo(int a, int n)
        {
            return a % n; 
        }
        
        // Je sais que j'aurai pu mettre les mêmes noms de variables pour chacune des fonctions. C'est pour éviter de me perdre au max

    }

}

