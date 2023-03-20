using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
        {
        static Trainee D = new DotNetTrainee();
        static Trainee C = new CrmTrainee();

        static void Main(string[] args)
            {
            
            Console.WriteLine("Which test you want to give?\n 1.DotNet \n 2.Crm");
                switch (Console.ReadLine())
                {
                    case "1":

                        //DotNetTrainee T = new DotNetTrainee();
                      
                        ThreadStart Th1 = new ThreadStart(D.Input);
                        Thread t1 = new Thread(Th1);
                        t1.Start();
                        t1.Join();  
                    
                        ThreadStart Th2 = new ThreadStart(D.Assessment);
                        Thread t2 = new Thread(Th2);
                        t2.Start();
                        t2.Join();
                    //Console.WriteLine("\nMarks = " + D.marks);

                    ThreadStart Th3 = new ThreadStart(D.Display);
                    Thread t3 = new Thread(Th3);
                    t3.Start();
                    t3.Join();

                
                    ThreadStart Th4 = new ThreadStart(D.FileWrite);
                    Thread t4 = new Thread(Th4);
                    t4.Start();
                    t4.Join();

                    ThreadStart Th9 = new ThreadStart(D.FileRead);
                    Thread t9 = new Thread(Th9);
                    t9.Start();
                    t9.Join();

                    break;

                    case "2":
                    //calling crmtrainee assessment

                    ThreadStart Th5 = new ThreadStart(C.Input);
                    Thread t5 = new Thread(Th5);
                    t5.Start();
                    t5.Join();

                    ThreadStart Th6 = new ThreadStart(C.Assessment);
                    Thread t6 = new Thread(Th6);
                    t6.Start();
                    t6.Join();
                    //Console.WriteLine("\nMarks = " + D.marks);

                    ThreadStart Th7 = new ThreadStart(C.Display);
                    Thread t7 = new Thread(Th7);
                    t7.Start();
                    t7.Join();
                    ThreadStart Th8 = new ThreadStart(C.FileWrite);
                    Thread t8 = new Thread(Th8);
                    t8.Start();
                    t8.Join();

                    ThreadStart Th10 = new ThreadStart(C.FileRead);
                    Thread t10 = new Thread(Th10);
                    t10.Start();
                    t10.Join();
                    break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                
                Console.ReadKey();
                //FileStream F = new FileStream(@"C:\vsassessment\file.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
                //File.WriteAllText(EmpId, Name, Address, Dob, Phone, T.Marks);
                //F.Close();
                }
        }
    }

