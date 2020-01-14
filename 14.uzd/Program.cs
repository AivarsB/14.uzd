using System;

namespace _14.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3;
            var y1 = 1;

            if (x <= y1)
            {
                Console.WriteLine($"Tilpums {x} litri der traukaa {y1} litrs");
            }

            else
            {
                Console.WriteLine($"Tilpums {x} litri neder traukaa {y1} litrs");
            }

            var y2 = 2;

            if (x <= y2)
            {
                Console.WriteLine($"Tilpums {x} litri der traukaa {y2} litri");
            }
            else
            {
                Console.WriteLine($"Tilpums {x} litri neder traukaa {y2} litri");
            }

            var y3 = 4;

            if (x <= y3)
            {
                Console.WriteLine($"Tilpums {x} litri der traukaa {y3} litri");
            }
            else
            {
                Console.WriteLine($"Tilpums {x} litri neder traukaa {y3} litri");
            }

            var y4 = 6;

            if (x <= y4)
            {
                Console.WriteLine($"Tilpums {x} litri der traukaa {y4} litri");
            }
            else
            {
                Console.WriteLine($"Tilpums {x} litri neder traukaa {y4} litri");
            }

            var y5 = 8;

            if (x <= y5)
            {
                Console.WriteLine($"Tilpums {x} litri der traukaa {y5} litri");
            }

            else
            {
                Console.WriteLine($"Tilpums {x} litri neder traukaa {y5} litri");
            }

        }
    }
}



// Mums ir ūdens 3L un 5 trauki atbilstoši ar tilpumu 1,2,4,6,8 L.
// Mūsu programmai ir jānosaka un jāizvada uz ekrāna, kuros traukos šo ūdeni mēs varam ieliet.
