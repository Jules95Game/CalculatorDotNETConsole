using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDotNETConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double ans = 1.635487;
            Console.WriteLine("Andwoord: {0:P2}.\n", ans);
            Console.WriteLine("Antwoord: {0:0.###}.\n", ans);
            Console.WriteLine("Antwoord: {0:C2}.\n", ans);
            */
            bool appRunning = true;

            while (appRunning)
            {
                Console.Clear();
                Console.WriteLine("C# Rekenmachine");
                //Standaart waarden variabelen
                string numInput1 = "";
                string numInput2 = "";

                //Invoer eerste getal
                Console.Write("\nTyp uw eerste getal: ");
                numInput1 = Console.ReadLine();

                //Converteer eerste invoer naar double
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("\n" +
                        "Dit is geen geldige invoer.\n" +
                        "Typ alstublieft een getal: ");
                    numInput1 = Console.ReadLine();
                }

                //Invoer tweede getal
                Console.Write("\nTyp uw tweede getal: ");
                numInput2 = Console.ReadLine();

                //Converteer tweede invoer naar double
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("\n" +
                        "Dit is geen geldige invoer.\n" +
                        "Typ alstublieft een getal: ");
                    numInput2 = Console.ReadLine();
                }

                //Berekening Keuzemenu
                Console.WriteLine("\n" +
                    "Welke berekening wilt u uitvoeren?\n" +
                    "\t o) Optellen\n" +
                    "\t a) Aftrekken\n" +
                    "\t v) Vermenigvuldigen\n" +
                    "\t d) Delen\n" +
                    "\n" +
                    "\t p) Percentage bepalen\n" +
                    "\n" +
                    "\t eo) Euro bedragen Optellen\n" +
                    "\t ea) Euro bedragen Aftrekken\n" +
                    "\t ev) Euro bedragen Vermenigvuldigen\n" +
                    "\t ed) Euro bedragen Delen");
                Console.Write("Uw keuze? ");
                string actie = Console.ReadLine();

                //Resultaat bepalen
                double rawResult = Calculator.DoOperation(cleanNum1, cleanNum2, actie);

                //Resultaat evalueren
                string tempResult = Convert.ToString(rawResult);
                while (tempResult == "NaN")
                {
                    Console.Write("\n" +
                        "Dit is geen geldige invoer.\n" +
                        "Kies een optie uit de lijst: ");
                    actie = Console.ReadLine();
                    rawResult = Calculator.DoOperation(cleanNum1, cleanNum2, actie);
                    tempResult = Convert.ToString(rawResult);
                }
                Console.WriteLine("");

                //Resultaat stijl bepalen en printen
                FormatAnswer.DoFormat(actie, cleanNum1, cleanNum2, rawResult);

                //Laat gebruiker kiezen om af te sluiten
                Console.Write("Typ x en Enter om te stoppen, " +
                    "of druk op Enter om door te gaan.");
                if (Console.ReadLine() == "x")
                    appRunning = false;
            }
        }
    }
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string opActie)
        {
            double rawResult = double.NaN;

            if (opActie == "o")
            {
                rawResult = num1 + num2;
                return rawResult;
            }
            else if (opActie == "a")
            {
                rawResult = num1 - num2;
                return rawResult;
            }
            else if (opActie == "v")
            {
                rawResult = num1 * num2;
                return rawResult;
            }
            else if (opActie == "d")
            {
                while(num2 == 0)
                {
                    Console.Write("\n" +
                        "Kan niet delen door nul.\n" +
                        "voer een ander getal in: ");
                    string newNum2 = Console.ReadLine();
                    while (!double.TryParse(newNum2, out num2))
                    {
                        Console.Write("\n" +
                            "Dit is geen geldige invoer.\n" +
                            "Typ alstublieft een getal: ");
                        newNum2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n" +
                        "Uw nieuwe tweede getal is :{0}\n" +
                        "Houd er rekening mee dat dit getal \n" +
                        "niet wordt weergegeven bij de uikomst.", num2);
                }
                rawResult = num1 / num2;
                return rawResult;
            }
            else if (opActie == "p")
            {
                while (num2 == 0)
                {
                    Console.Write("\n" +
                        "Kan niet delen door nul.\n" +
                        "voer een ander getal in: ");
                    string newNum2 = Console.ReadLine();
                    while (!double.TryParse(newNum2, out num2))
                    {
                        Console.Write("\n" +
                            "Dit is geen geldige invoer.\n" +
                            "Typ alstublieft een getal: ");
                        newNum2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n" +
                        "Uw nieuwe tweede getal is :{0}\n" +
                        "Houd er rekening mee dat dit getal \n" +
                        "niet wordt weergegeven bij de uikomst.", num2);
                }
                rawResult = num1 / num2;
                return rawResult;
            }
            else if (opActie == "eo")
            {
                rawResult = num1 + num2;
                return rawResult;
            }
            else if (opActie == "ea")
            {
                rawResult = num1 - num2;
                return rawResult;
            }
            else if (opActie == "ev")
            {
                rawResult = num1 * num2;
                return rawResult;
            }
            else if (opActie == "ed")
            {
                while (num2 == 0)
                {
                    Console.Write("\n" +
                        "Kan niet delen door nul.\n" +
                        "voer een ander getal in: ");
                    string newNum2 = Console.ReadLine();
                    while (!double.TryParse(newNum2, out num2))
                    {
                        Console.Write("\n" +
                            "Dit is geen geldige invoer.\n" +
                            "Typ alstublieft een getal: ");
                        newNum2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n" +
                        "Uw nieuwe tweede getal is :{0}\n" +
                        "Houd er rekening mee dat dit getal \n" +
                        "niet wordt weergegeven bij de uikomst.", num2);
                }
                rawResult = num1 / num2;
                return rawResult;
            }
            else
            {
                return rawResult;
            }
        }
    }
    class FormatAnswer
    {
        public static void DoFormat(string stijlActie,
            double num1,
            double num2,
            double rawResult)
        {
            if (stijlActie == "o")
            {
                Console.WriteLine("{0} + {1} = {2}",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "a")
            {
                Console.WriteLine("{0} - {1} = {2}",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "v")
            {
                Console.WriteLine("{0} x {1} = {2}",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "d")
            {
                Console.WriteLine("{0} : {1} = {2}",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "p")
            {
                Console.WriteLine("{0} is \"{2:P2}\" van {1}.",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "eo")
            {
                Console.WriteLine("{0:N} euro, plus {1:N} euro, is {2:N} euro.",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "ea")
            {
                Console.WriteLine("{0:N} euro, min {1:N} euro, is {2:N} euro.",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "ev")
            {
                Console.WriteLine("{0:N} euro, keer {1:N} euro, is {2:N} euro.",
                    num1,
                    num2,
                    rawResult);
            }
            else if (stijlActie == "ed")
            {
                Console.WriteLine("{0:N} euro, gedeeld door {1:N} euro, is {2:N} euro.",
                    num1,
                    num2,
                    rawResult);
            }
        }
    }
}
