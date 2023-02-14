using System;

namespace tools{

    public static class Tools
    {
        // Genere un nombre aléatoire entre 1 et 100
        public static int jet()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            return number;
        }
    }
 
}


