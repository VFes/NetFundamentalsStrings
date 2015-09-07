using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Go to your c:\\\\ drive"; //you need two \ to display one
            Console.WriteLine(myString);

            string myString2 = "My \"so called\" life";// you need \" to diisplay one "
            Console.WriteLine(myString2);

            string myString3 = "What if I need \n a new line?";
            Console.WriteLine(myString3);

            string myString4 = string.Format("It will print {0}!", "Bonzai");
            Console.WriteLine(myString4);

            string myString5 = string.Format("Make: {0} (Model: {1})", "BMW", "760LI");
            Console.WriteLine(myString5);

            string myString6 = string.Format("{0:C}", 123.45);
            Console.WriteLine(myString6);

            string myString7 = string.Format("{0:N}", 123456789);
            Console.WriteLine(myString7);

            string myString8 = string.Format("{0:P}", 1.0);
            Console.WriteLine(myString8);

            string myString9 = string.Format("Phone number: {0:(###) ##-##-###}", 4433766860);
            Console.WriteLine(myString9);

            string myString10 = "";

            for (int i = 0; i <= 99; i++)
            {
                //myString10 = myString10 + "--" + i.ToString();
                myString10 += "--" + i.ToString();
            }

            Console.WriteLine(myString10);

            StringBuilder myString11 = new StringBuilder(); //This one uses less resources, it is made for multiple concatenations

            for (int i = 0; i <= 99 ; i++)
            {
                myString11.Append("--");
                myString11.Append(i);
            }

            Console.WriteLine(myString11);

            string myString12 = "Endless darkness! screaming echoes of silence! embraced by shadows! they take me appart!";

            Console.WriteLine(myString12);

            myString12 = myString12.Replace(" ", "--");

            Console.WriteLine(myString12);

            myString12 = myString12.Replace("--", " ");

            myString12 = myString12.Substring(0, 17);

            Console.WriteLine(myString12);
            Console.WriteLine(myString12.ToUpper());

            string myString13 = " that summer we took threes across the board ";
            myString13 = string.Format("Using TRIM in a string: Length before: {0} -- After:{1}", myString13.Length, myString13.Trim().Length);
            Console.WriteLine(myString13);

            

            Console.ReadLine();
        }
    }
}
