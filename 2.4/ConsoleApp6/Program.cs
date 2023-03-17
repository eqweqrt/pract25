using System;

namespace ConsoleApp24
{
    class Program
    {
        public static void Main(string[] args)
        {
            string rim = " MDIX ";

            int sum = 0;

                for (int i = 1; i < rim.Length - 1; i++)
                {
                    switch (rim[i])
                    {
                        case 'I' :
                        {
                            if (rim[i+1] == 'V')
                            {
                                sum += 4;
                            }
                            
                            else if (rim[i+1] == 'X')
                            {
                                sum += 9;
                            }
                            else
                            {
                                sum += 1;
                            }
                            break;
                        }
                        case 'V' :
                        {
                            sum += 5;
                            break;
                        }
                        case 'X' :
                        {
                            if(rim[i+1] == 'L')
                            {
                                sum = sum + 40;
                            }
                            else if (rim[i+1] == 'C')
                            {
                                sum = sum + 90;
                            }
                            else
                            {
                                sum += 10;
                            }
                            break;
                        }
                        case 'L' :
                        {
                            sum += 50;
                            break;
                        }
                        case 'C' :
                        {
                            if(rim[i+1] == 'D')
                            { 
                                sum += 400;
                            }
                            else if (rim[i+1] == 'M')
                            {
                                sum += 900;
                            }
                            else
                            {
                                sum += 100;
                            }

                            sum +=300;
                            break;
                        }
                        case 'D' :
                        {
                            sum += 500;
                            break;
                        }
                        case 'M' :
                        {
                            sum += 1000;
                            break;
                        }
                    }
                }
                Console.WriteLine(sum);
        }
    }
}

