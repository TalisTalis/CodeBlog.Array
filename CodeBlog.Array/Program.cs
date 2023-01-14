using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog.Array
{
    internal class Program
    {
        enum Stages
            {
                analysis,
                repair,
                performance,
                disassembly,
                revision = 2,
                setting,
                assembly,
                firstinclusion
            }
        static void Main(string[] args)
        {
            int[] arr = { 43, 12, 7, 61, 0 };

            List<int> list = new List<int>()
            { 
                43,
                12,
                7,
                61,
                0
            };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i} элемент массива arr[] = {arr[i]}");
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} элемент списка list = {list[i]}");
            }

            Console.WriteLine($"Прибор на этапе {Stages.firstinclusion}");
        }
    }
}
