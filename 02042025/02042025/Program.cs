using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _02042025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cont = 0;

            List<int> nums = new List<int>();
            Dictionary<int, int> misNumeros = new Dictionary<int, int>(); 

            nums.Add(15);
            nums.Add(26);
            nums.Add(37);
            nums.Add(49);
            nums.Add(54);
            nums.Add(63);
            nums.Add(76);
            nums.Add(87);
            nums.Add(92);
            nums.Add(10);

            for (int i = 0; i < nums.Count; i++)
            {

                misNumeros.Add(i, nums[i]);

            }

            foreach (KeyValuePair<int, int> x in misNumeros)
            { 
            
                Console.WriteLine($"Key: {x.Key} Value: {x.Value}");
            
            }



        }
    }
}
