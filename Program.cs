using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem_game
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstColour, SecondColour, Crush ; 

            Console.Write ( " Enter a colour: " );
            FirstColour = (Console.ReadLine());

            Console.Write ( " Enter another colour: " );
            SecondColour = (Console.ReadLine());

            Console.Write ( " Enter name of your crush: " );
            Crush = (Console.ReadLine());


            Console.WriteLine(" Roses are " + FirstColour );
            Console.WriteLine( " Violet are " + SecondColour );
            Console.WriteLine(" I love " + Crush );

            Console.ReadLine();
        }
    }
}
