using System;
using System.Text;

namespace CG6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayName = true;

            while (displayName)

            {

                displayName = FullName();

            }
        }
        private static bool FullName()


        {
            Console.WriteLine("What is your first name?");
            Console.Write("Enter name here:");
            
            string fn;
            fn = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Console.Write("Enter name here:");
            
            string ln;
            ln = Console.ReadLine();

            Console.WriteLine("Do you want your first name first, or last name first?");
            Console.Write("Select 1 for first name first or 2 for last name first:");
           
            string result;
            result = Console.ReadLine();

            if (result == "1")
            {
                Console.WriteLine( FirstLast( fn,  ln));
                Console.ReadLine();
                
                return true;
                
            }

            else if (result == "2")
            {
                Console.Write( LastFirst(fn, ln));
                Console.ReadLine();
                return true;
            }

            else
            {
                return false;
            }

            

             
        }
        private static string FirstLast(string fn, string ln)
        {
            StringBuilder firstN = new StringBuilder();
            firstN.Append(fn + " " + ln + "!");
            Console.WriteLine(firstN.ToString());
            return fn;           

        }
        private static string LastFirst(string fn, string ln)
        {
            StringBuilder lastn = new StringBuilder();
            lastn.Append(ln + " " + fn + "!");
            Console.WriteLine(lastn.ToString());
            return ln;
        }
        
        
        

    }
    
}
