using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class AlgorithmRunner
    {
        public static void RunAlgorithm(AlgorithmBase algorithm)
        {
            Console.WriteLine($"Çalıştırılıyor: {algorithm.GetType().Name}");
            algorithm.Run();
        }
    }
}
