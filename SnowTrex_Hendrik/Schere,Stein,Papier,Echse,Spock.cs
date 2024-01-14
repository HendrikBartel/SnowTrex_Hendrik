using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie wollen Sie genannt werden?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hallo " + Name + "!" );

            Console.WriteLine("Was ist dein Zug?");

            Console.WriteLine("Wählen Sie Ihren Zug (\"Schere,Stein,Papier,Echse oder Spock\")");

         int anzahlSiege = 0;   
            
            while (anzahlSiege < 3) 
            {
                string eingabe1 = Console.ReadLine();

                Random r = new Random();

                int computerAuswahl = r.Next(1, 6);
                //Stein = 1
                //Schere = 2
                //Papier = 3
                //Echse = 4
                //Spock = 5
        
        
                if (computerAuswahl == 1)
                {
                    if (eingabe1 == "Stein")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Unentschieden - Neuer Versuch!");
                    }
                    else if (eingabe1 == "Schere")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Papier")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Echse")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Spock")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                        }
                }
                if (computerAuswahl == 2)
                {
                    if (eingabe1 == "Stein")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                        }
                    else if (eingabe1 == "Schere")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt!");
                        Console.WriteLine("Unentschieden - Neuer Versuch!");
                    }
                    else if (eingabe1 == "Papier")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Echse")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Spock")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                }
                if (computerAuswahl == 3)
                {
                    if (eingabe1 == "Stein")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Schere")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Papier")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt!");
                        Console.WriteLine("Unentschieden - Neuer Versuch!");
                    }
                    else if (eingabe1 == "Echse")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Spock")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt!");
                        Console.WriteLine("Verloren");
                    }
                }
                if (computerAuswahl == 4)
                {
                    if (eingabe1 == "Stein")
                    {
                        Console.WriteLine("Der Computer hat Echse gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Schere")
                    {
                        Console.WriteLine("Der Computer hat Echse gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Papier")
                    {
                        Console.WriteLine("Der Computer hat Echse gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Echse")
                    {
                        Console.WriteLine("Der Computer hat Echse gewählt!");
                        Console.WriteLine("Unentschieden - Neuer Versuch!");
                    }
                    else if (eingabe1 == "Spock")
                    {
                        Console.WriteLine("Der Computer hat Echse gewählt!");
                        Console.WriteLine("Verloren");
                    }
                }
                if (computerAuswahl == 5)
                {
                    if (eingabe1 == "Stein")
                    {
                        Console.WriteLine("Der Computer hat Spock gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Schere")
                    {
                        Console.WriteLine("Der Computer hat Spock gewählt!");
                        Console.WriteLine("Verloren");
                    }
                    else if (eingabe1 == "Papier")
                    {
                        Console.WriteLine("Der Computer hat Spock gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Echse")
                    {
                        Console.WriteLine("Der Computer hat Spock gewählt!");
                        Console.WriteLine("Gewonnen");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else if (eingabe1 == "Spock")
                    {
                        Console.WriteLine("Der Computer hat Spock gewählt!");
                        Console.WriteLine("Unentschieden - Neuer Versuch!");
                    }
                    
                }

                   // if (anzahlSiege > 0) ;
                   // {
                   //     Console.WriteLine("3 Mal gewonnen! Herzlichen Glückwunsch!");
                  //  }










            }
            
        } 
    }
}