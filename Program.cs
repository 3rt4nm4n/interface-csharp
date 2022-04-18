using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Nummer num = new Nummer(n1, n2);
            Console.WriteLine("\nSummation: " + num.topla() + "\nSubtraction: " + num.cikar() + "\nMultiplication: " + num.carp() + "\nDivision: " + num.bol());
            Console.ReadKey();
            
        }

       
    }

    class Nummer : IIslem
    {
        private int n1;
        private int n2;

        public Nummer(int num1,int num2)
        {
            n1 = num1;
            n2 = num2;
        }

        public int bol() //division function
        {
            return n1 / n2;
        }

        public int carp() //multiplication function
        {
            return n1 * n2;
        }

        public int cikar() //subtraction function
        {
            return n1 - n2;
        }

        public int topla() //summation function
        {
            return n1 + n2;
        }
    }

    public interface IIslem
    {
        int topla();
        int cikar();
        int bol();
        int carp();
    }
}
