
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IP与掩码合格性检验
{
    class Program
    {
        static int[] Count = new int[7];

        static void Main(string[] args)
        {

            string line="";
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                bool valid = true;
                string[] ipandmask = line.Split(new char[] { '~' });
                if (ipandmask.Length == 2)
                {
                    string ip = ipandmask[0];
                    string mask = ipandmask[1];
                    //mask check valid
                    
                    bool MaskValid = MaskChecker(mask);
                    if (MaskValid == false)
                    {
                        Count[5]++;
                        continue;
                    }
                    //ip check valid
                    string[] ipSplits = ip.Split(new char[] { '.' },StringSplitOptions.RemoveEmptyEntries);
                    if (ipSplits.Length == 4)
                    {
                        int high_0 = int.Parse(ipSplits[0]);
                        int high_1 = int.Parse(ipSplits[1]);
                        int high_2 = int.Parse(ipSplits[2]);
                        int high_3 = int.Parse(ipSplits[3]);
                        if (!IPChecker(high_0, high_1, high_2, high_3))
                        {
                            Count[5]++;
                            continue;
                        }
                        else
                        {
                            if (high_0 >= 1 && high_0 <= 126)
                            {
                                Count[0]++;
                            }
                            else if (high_0 >= 128 && high_0 <= 191)
                            {
                                Count[1]++;
                            }
                            else if (high_0 >= 192 && high_0 <= 223)
                            {
                                Count[2]++;
                            }
                            else if (high_0 >= 224 && high_0 <= 239)
                            {
                                Count[3]++;
                            }
                            else if (high_0 >= 240 && high_0 <= 255)
                            {
                                Count[4]++;
                            }


                            //siyou
                            if (valid == true)
                            {
                                if (high_0 == 10)
                                    Count[6]++;
                                else if (high_0 == 172 && high_1 >= 16 && high_1 <= 31)
                                    Count[6]++;
                                else if (high_0 == 192 && high_1 == 168)
                                    Count[6]++;

                            }
                        }
                        
                        
                    }
                    else
                        valid = false;

                }
                else
                    valid = false;
                if (valid == false)
                    Count[5]++;
                
            }
            for(int i=0;i<Count.Length;i++)
            {
                if (i != 0)
                    Console.Write(" ");
                Console.Write(Count[i]);
            }
            Console.ReadLine();

        }

        static bool IPChecker(int high_0,int high_1,int high_2,int high_3) 
        {
            bool valid = true;
            if (high_0>=0 && high_0 <=255 && high_1 >= 0 && high_1 <= 255 && high_2 >= 0 && high_2 <= 255
                            && high_3 >= 0 && high_3 <= 255)
            {
                if (high_0 == 0)
                {

                }
                else if (high_0 >= 1 && high_0 <= 126)
                {
                }
                else if (high_0 >= 128 && high_0 <= 191)
                {
                }
                else if (high_0 >= 192 && high_0 <= 223)
                {
                }
                else if (high_0 >= 224 && high_0 <= 239)
                {
                }
                else if (high_0 >= 240 && high_0 <= 255)
                {
                }
                else
                {
                    //Console.WriteLine(high_0 + "" + high_1 + "" + high_2 + "" + high_3);
                    valid = false;
                }
            }
            else
                valid = false;
            return valid;
        }


        static bool MaskChecker(string mask) 
        {
            bool valid = true;
            string[] maskSplits = mask.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (maskSplits.Length == 4)
            {
                bool headOne = true;
                for (int i = 0; i < 4; i++)
                {
                    int temp = int.Parse(maskSplits[i]);
                    for (int j = 7; j >= 0; j--)
                    {
                        if ((temp / (int)Math.Pow(2, j)) > 0)
                        {
                            temp %= (int)Math.Pow(2, j);
                            if (!headOne)
                                valid = false;
                        }
                        else
                            headOne = false;
                    }
                }
                if (headOne == true)
                    valid = false;
            }
            else
                valid = false;
            return valid;
        }



    }
}
