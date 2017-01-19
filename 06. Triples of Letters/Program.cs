using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstChar = 0; firstChar < number; firstChar++)
            
                for (int secondChar = 0; secondChar < number; secondChar++)
                
                    for (int thirdChar = 0; thirdChar <number; thirdChar++)
                    { 
                        char firstLetter = (char)('a' +firstChar);
                        char secondLetter = (char)('a' + secondChar);
                        char thirdLetter = (char)('a' + thirdChar);

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                    
                }
            }
            
        }
    

