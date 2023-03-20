using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
  
        class CrmTrainee : Trainee
        {


            public override void Assessment()
            {
                int Correct = 0;
                string input = "";

                string[] mcq = {"According to ___, CRM is an iterative process that turns customer information into positive customer relations.\na). Ronald S. Swift\n b). Stanley A. Brown\n c). Chris Todman\n d). Gartner Group",
               "2) CRM is a business philosophy that aims at maximizing ___ in the long run\n a). Organization value\n b). Customer value\n c). Business value\n d). Software value",
            "3) The objective of data mining is to detect ___ relationships among data\n a). Vendor\n b). Customer\n c). Application\n d). Hidden"};
                Console.WriteLine("\n-------------------CRM Assessment--------------------\n");
                for (int i = 0; i < mcq.Length; i++)
                {
                    Console.WriteLine(mcq[i]);
                    input = Console.ReadLine();
                    if ((i == 0) && (input == "a"))
                    { Correct += 1; }
                    if ((i == 1) && (input == "b"))
                    { Correct += 1; }
                    if ((i == 2) && (input == "d"))
                    { Correct += 1; }
                }

                marks = Convert.ToString(Correct);

            }


        }
    }

