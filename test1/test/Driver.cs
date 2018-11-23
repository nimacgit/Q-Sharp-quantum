﻿using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace test
{
    class Driver
    {
        static void Main(string[] args)
        {
            using(var init = new QuantumSimulator()){
                Solve(init, 1)
            }
            //  using (var sim = new QuantumSimulator())
            // {
            //     // Try initial values
            //     Result[] initials = new Result[] { Result.Zero, Result.One };
            //     foreach (Result initial in initials)
            //     {
            //         var res = BellTest.Run(sim, 1000, initial).Result;
            //         var (numZeros, numOnes) = res;
            //         System.Console.WriteLine(
            //             $"Init:{initial,-4} 0s={numZeros,-4} 1s={numOnes,-4}");
            //     }
            // }
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}