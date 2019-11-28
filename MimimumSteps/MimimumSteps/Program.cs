using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese enter your instructions separated by ',' Eg: F3,R2,B6,L4,F4");
            String move1 = Console.ReadLine();
            string move = move1.ToUpper();
            Console.WriteLine("Move instrunctions : " + move);
            string[] commands = move.Split(",");
            var t = Math.Abs(finalPosition(commands));
            Console.WriteLine("The Minimum Number of Steps to Get back to Original Position:" + t);
            Console.ReadLine();
        }

        public static int finalPosition(string[] move)
        {
            var result = 0;
            string[] initialLocation = new string[4];
            initialLocation[0] = "0";
            initialLocation[1] = "0";
            initialLocation[2] = "N";
            initialLocation[3] = "0";
            for (int i = 0; i <= move.Length - 1; i++)
            {
                if (move[i].ToCharArray()[0] == 'F')
                {
                    //CHECK THE DIRECTION move
                    if (initialLocation[2] == "N")
                    {
                        initialLocation[1] = (Int32.Parse(initialLocation[1]) + Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();

                    }
                    else if (initialLocation[2] == "S")
                    {
                        initialLocation[1] = (Int32.Parse(initialLocation[1]) - Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();

                    }
                    else if (initialLocation[2] == "E")
                    {
                        initialLocation[0] = (Int32.Parse(initialLocation[0]) + Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();

                    }
                    else if (initialLocation[2] == "W")
                    {
                        initialLocation[0] = (Int32.Parse(initialLocation[0]) - Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();

                    }
                }
                else if (move[i].ToCharArray()[0] == 'B')
                {
                    //CHECK THE DIRECTION 
                    if (initialLocation[2] == "N")
                    {
                        initialLocation[1] = (Int32.Parse(initialLocation[1]) - Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();
                    }
                    else if (initialLocation[2] == "S")
                    {
                        initialLocation[1] = (Int32.Parse(initialLocation[1]) + Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();
                    }
                    else if (initialLocation[2] == "E")
                    {
                        initialLocation[0] = (Int32.Parse(initialLocation[0]) - Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();
                    }
                    else if (initialLocation[2] == "W")
                    {
                        initialLocation[0] = (Int32.Parse(initialLocation[0]) + Int32.Parse((move[i].ToCharArray()[1]).ToString())).ToString();
                        initialLocation[3] = (Math.Abs((Int32.Parse(initialLocation[0]))) + Math.Abs(Int32.Parse(initialLocation[1]))).ToString();
                    }
                }
                else if (move[i].ToCharArray()[0] == 'R')
                {
                    for(int j=0; j < Int32.Parse((move[i].ToCharArray()[1]).ToString()); j++)
                    {
                        //CHECK THE DIRECTION 
                        if (initialLocation[2] == "N")
                        {
                            initialLocation[2] = "E";

                        }
                        else if (initialLocation[2] == "S")
                        {
                            initialLocation[2] = "W";
                        }
                        else if (initialLocation[2] == "E")
                        {
                            initialLocation[2] = "S";
                        }
                        else if (initialLocation[2] == "W")
                        {
                            initialLocation[2] = "N";
                        }
                    } 
                }
                else if (move[i].ToCharArray()[0] == 'L')
                {
                    for (int j = 0; j < Int32.Parse((move[i].ToCharArray()[1]).ToString()); j++)
                    {
                        //CHECK THE DIRECTION 
                        if (initialLocation[2] == "N")
                        {
                            initialLocation[2] = "W";
                        }
                        else if (initialLocation[2] == "S")
                        {
                            initialLocation[2] = "E";
                        }
                        else if (initialLocation[2] == "E")
                        {
                            initialLocation[2] = "N";
                        }
                        else if (initialLocation[2] == "W")
                        {
                            initialLocation[2] = "S";
                        }
                    }
                }
            }
            result = Int32.Parse(initialLocation[3]);
            return result;
        }
    }
}