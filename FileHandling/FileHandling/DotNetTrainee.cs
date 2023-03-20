using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
  
        class DotNetTrainee : Trainee
        {

            public DotNetTrainee()
            {

            }
            public override void Assessment()
            {
                int Correct = 0;
                string input = "";

                string[] mcq = {"1) ______is an agreement among language designers and class library designers to use a common subset of basic language features that all languages have to follow.\n a) Common Language Specifications(CLS)\n b) Common Language Runtime(CLR)\n c) Common Type System(CTS)\n d) Framework Class Library(FCL)",
               "2) The .NET Framework Class Library (FCL) is also known as\n a)Base Class Library (BCL)\n b)Common Class Library (CCL)\n c)Global Class Library (GCL)\n d)Public Class Library (PCL)",
            "3) ______will verify types used in the application with CTS or CLS standards supported by CLR.\na) Exception manager\n b) Type checker\n c) Code manager\n d) Class loader"
            };

                Console.WriteLine("\n-------------------DotNetAssessment--------------------\n");

                for (int i = 0; i < mcq.Length; i++)
                {
                    Console.WriteLine(mcq[i]);
                    input = Console.ReadLine();
                    if ((i == 0) && (input == "a"))
                    { Correct += 1; }
                    if ((i == 1) && (input == "a"))
                    { Correct += 1; }
                    if ((i == 2) && (input == "b"))
                    { Correct += 1; }
                }

                marks = Convert.ToString(Correct);



            }

        }
    }

