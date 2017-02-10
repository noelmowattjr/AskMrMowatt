using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _roughDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A photo recognition app that identifies objects in real time photos, but identifies them in French.*/

            //--name prompt
            Console.Write("Hi, what is your name: ");
            string name = Console.ReadLine();

            string greetings = timeOfDay(name);
            Console.WriteLine(greetings);
        }

        //--Method greets user according to time of day
        static string timeOfDay(string name)
        {
            //--datetime object created
            DateTime datetime = new DateTime();

            //--Instantiate time to output real time
            datetime = DateTime.Now;

            //--Conditional greetings for time of day--//
            if (datetime.Hour >= 0 && datetime.Hour < 12)
            {
                Console.WriteLine("Bonjour, {0}!", name);
            }
            else if (datetime.Hour >= 12 && datetime.Hour < 16)
            {
                Console.WriteLine("Bonne apres-midi, {0}!", name);
            }
            else if (datetime.Hour >= 16 && datetime.Hour < 19)
            {
                Console.WriteLine("Bonsoir, {0}!", name);
            }
            else if (datetime.Hour >= 20)
            {
                Console.WriteLine("Bonne nuit, {0}!", name);
            }

            return "";
        }
    }
}
