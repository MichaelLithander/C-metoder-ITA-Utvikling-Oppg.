using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Slett9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kall på metodene som er definert under.
            //Der hvor det er en return, opprett variabel for å holde på returverdien

            SkrivHei(); //Kaller på SkrivHei

            string hei = ReturnerHei(); //Lager variabel for å holde returverdien fra ReturnerHei
            Console.WriteLine(hei); //Skriver ut returverdien

            SkrivNoe("Dette er tilfeldig tekst sendt til metoden SkrivNoe."); //Kaller på SkrivNoe med en tekst

            int sum = Add(3, 4); //Lager variabel for returverdien fra Add
            Console.WriteLine("Summen er: " + sum); //Skriver ut returverdien

            AddNoReturn(5, 7); //Kaller på AddNoReturn med to tall

            Console.ReadLine();//for at consolet ikke skal stenges
        }

        public static void SkrivHei()
        {
            Console.WriteLine("Hei"); //Kodelinjen som skriver hei ut til console
        }

        
        public static string ReturnerHei()
        {
            string bolle = "Hei";
            return bolle;
        }

        public static void SkrivNoe(string tekst)
        {
            Console.WriteLine(tekst);
        }

        
        public static int Add(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        public static void AddNoReturn(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
}
