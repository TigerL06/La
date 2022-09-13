using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1__Lernatellierprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
                
                int Benutzernummer;
                Benutzernummer = 1;
                int Count = 0;
                Random rnd = new Random();
                int Geheimzahl = rnd.Next(1, 101);
                Console.WriteLine("Willkommen zu meinem Numberguesser. ");
                Console.WriteLine("Dieses Programm wurde von Liam Gideon Koch programmiert. ");
                Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein: ");

            while (Geheimzahl < Benutzernummer | Geheimzahl > Benutzernummer)
            {
                Count = Count + 1;





                try
                {
                    Benutzernummer = Convert.ToInt32(Console.ReadLine());
                    if (Benutzernummer > 100)
                    {
                        throw new Exception();
                    }

                    if (Benutzernummer <= 100)
                    {

                        if (Geheimzahl > Benutzernummer | Geheimzahl < Benutzernummer)
                        {
                            Console.WriteLine("Ihre Zahl ist falsch, versuchen sie es erneut:");

                            if (Benutzernummer < Geheimzahl)
                            {
                                Console.WriteLine("Ihre Zahl ist kleiner als die Zufallszahl. ");

                            }
                            else if (Benutzernummer > Geheimzahl)
                            {
                                Console.WriteLine("Ihre Zahl ist grösser als die Zufallszahl:");
                            }
                        }



                    }
                    

                }
                catch
                {
                    Console.WriteLine("Fehler");
                    Console.WriteLine("Geben sie erneut eine Zahl zwischen 1 und 100 ein: ");
                }

            }
            
            if (Geheimzahl == Benutzernummer)
            {
                Console.WriteLine("Sie haben die Zahl erhausgefunden.");
                Console.WriteLine("Sie brauchten " + Convert.ToString(Count) + " Versuche");
            }

        }
    }
}