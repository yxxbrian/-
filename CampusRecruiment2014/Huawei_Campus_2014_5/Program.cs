using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huawei_Campus_2014_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input0 = Console.ReadLine();
            string input1 = Console.ReadLine();
            string[] inputs0 = input0.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> validedInputs = new List<string>();
            foreach (string str in inputs0)
            {
                if (str.Contains(input1))
                    validedInputs.Add(str);
            }
            int[] inputsints = new int[validedInputs.Count];
            int index = 0;
            foreach (string str in validedInputs)
            {
                inputsints[index++] = int.Parse(str);
            }
            bool changed = true;
            while (changed)
            {
                changed = false;
                for(int i=0;i<inputsints.Length-1;i++)
                {
                    if (inputsints[i] > inputsints[i + 1])
                    {
                        int temp = inputsints[i];
                        inputsints[i] = inputsints[i + 1];
                        inputsints[i + 1] = temp;
                        changed = true;
                    }
                }
            }
            for (int i = 0; i < inputsints.Length; i++) 
            {
                Console.Write(inputsints[i]);
                if (i != inputsints.Length)
                    Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
