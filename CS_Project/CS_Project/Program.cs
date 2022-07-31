using System;

namespace CS_Project
{
    class Program
    { 
        static void Main(string[] args)
        {
            MakeStar();
        }

        // Make Star //
        static void MakeStar() {
            // Graphic //
            string Graphic = "";
            
            // Star Setting //
            for (int i = 0;  i < 5; i++) {
                for (int j = 0; j < 5 - i; j++) Graphic += "*"; // Fi
                for (int j = 0; j < 10 - (5 - i) * 2; j++) Graphic += " "; // Se
                for (int j = 0; j < 5 - i; j++) Graphic += "*"; // Th
                Graphic += "\n"; 
            }

            // Draw //
            Console.WriteLine(Graphic);
        }
    }
}
