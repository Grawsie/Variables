using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine();
            Console.WriteLine("By Ryan");


            // variables
            
            //integers
            int score; // declaration - declare "score" is an int
            score = 0; // initialization - init. "score" to be 0.
            int enemyPoints;
            enemyPoints = 100;


           Console.WriteLine("Score: " + score); // display score

            score = score + enemyPoints;

                Console.WriteLine("Score: " + score);



            //floating points
            //1.5
            //100.43456754

            float lapTime; // declaration
            lapTime = 0.0f; //initialization
            Console.WriteLine(lapTime);
            lapTime = 65.357f;
            Console.WriteLine(lapTime);




            // string (text)

            string title; // declaration
            title = "Newbie";
            Console.WriteLine(title);
            title = "Pro";
            Console.WriteLine(title);
            Console.ReadKey(true);
            
        }
    }
}
