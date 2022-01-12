using System;
using System.Linq;

namespace Epam
{
    class Convert
    {
        public static string ConvertTensToN(int number, int n)
        {
            string done = "";
            string str = "";

            if (n >= 11)
            {
                while (number > 0)
                {
                    switch (number % n)
                    {
                        case 10:
                            {
                                str += "A";
                                number /= n;
                                break;
                            }

                        case 11:
                            {
                                str += "B";
                                number /= n;
                                break;
                            }

                        case 12:
                            {
                                str += "C";
                                number /= n;
                                break;
                            }

                        case 13:
                            {
                                str += "D";
                                number /= n;
                                break;
                            }

                        case 14:
                            {
                                str += "E";
                                number /= n;
                                break;
                            }

                        case 15:
                            {
                                str += "F";
                                number /= n;
                                break;
                            }

                        case 16:
                            {
                                str += "G";
                                number /= n;
                                break;
                            }

                        case 17:
                            {
                                str += "H";
                                number /= n;
                                break;
                            }

                        case 18:
                            {
                                str += "I";
                                number /= n;
                                break;
                            }

                        case 19:
                            {
                                str += "J";
                                number /= n;
                                break;
                            }

                        case 20:
                            {
                                str += "K";
                                number /= n;
                                break;
                            }

                        default:
                            {
                                str += number % n;
                                number /= n;
                                break;
                            }
                    }
                }
            }

            else
            {
                while (number > 0)
                {
                    str += (number % n).ToString();
                    number /= n;
                }
            }

            foreach (var item in str.Reverse())
            {
                done += item;
            }

            return done;
        }
    }
}
