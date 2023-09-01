using System.Net.NetworkInformation;
using System.Resources;

namespace TemperaturIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatur;
            bool res = false;


            while (res == false)
            {
                Console.WriteLine("Tast inn en temperatur, ett heltall");
                string temp = Console.ReadLine();


                res = int.TryParse(temp,out temperatur);

 

                if (res == true)
                {
                    if (temperatur < 0)
                    {
                        Console.WriteLine("Det er minusgrader");
                    }
                    else if (temperatur > 0)
                    {
                        Console.WriteLine("Det er plussgrader");
                    }
                    else
                    {
                        Console.WriteLine("Det er akuratt 0 grader");
                    }
                }
                else 
                {
                    Console.WriteLine("venligst skriv et faktisk tall og ikke en bokstav");
                    Console.WriteLine(" "); //Her for å lage litt space slik at den linja over og
                                            //den første tekst linja ikke blir skvist sammen
                }
            }

            TemperatureV2();

            Console.ReadLine();


        }
        static void TemperatureV2()
        { 
            int temperature;
            bool res = false;

            do
            {
                Console.WriteLine("V2 Tast inn en temperatur et heltall takk");

                string answer = Console.ReadLine();

                res = int.TryParse(answer, out temperature);

                if (res == true)
                {
                    if (temperature < 0)
                    {
                        Console.WriteLine("Det er minusgrader");
                    }
                    else if (temperature > 0)
                    {
                        Console.WriteLine("Det er plussgrader");
                    }
                    else
                    {
                        Console.WriteLine("Det er 0 grader");
                    }
                }
                else {
                    Console.WriteLine("Venligst tast inn et gylidg tall. Et tall, ikke noe mer ikke noe mindre");
                    Console.WriteLine(" "); //Her for å lage litt space slik at den linja over og
                                            //den første tekst linja ikke blir skvist sammen
                }
            }
            while (res == false);

        }


    }
}