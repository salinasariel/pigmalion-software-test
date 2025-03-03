using System;
using System.Diagnostics;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int[] nums = [1,4,3,9];
        //int[] nums = [1,2,4,4];

        int requiredSum = 8;
        bool targetEjercicio1, targetEjercicio2;

        
        Console.WriteLine(E1(nums, requiredSum));
        Console.WriteLine(E2(nums, requiredSum));



        Stopwatch watch = new();
        watch.Start();
        targetEjercicio1 = E1(nums, requiredSum);
        Console.WriteLine($"E1 {watch.ElapsedMilliseconds} ms. {targetEjercicio1}");
        watch.Stop();


        watch.Start();
        targetEjercicio2 = E2(nums, requiredSum);
        Console.WriteLine($"E2: {watch.ElapsedMilliseconds} ms. {targetEjercicio2}");
        watch.Stop();

        

    }

    static bool E2(int[] nums, int requiredSum)
    {
        bool target = false;

        //Recorro el array tomando pibote i

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                // Sumo el pibote i con j
                //Console.WriteLine(current + " + " + nums[j]+ "=" + (current + nums[j]));
                if (current + nums[j] == requiredSum)
                {
                    target = true;
                    return target;
                }

            }
            
        }
        return target;
    }

    static bool E1(int[] nums, int requiredSum)
    {
        //List vacio donde voy a ir almacenando de a uno los elementos del array 
        List<int> exitstant = [];

        foreach (int i in nums) 
        {
            // si la diferencia de requiredSum y el elemento, esta almacenado en mi list, devuelvo true
            int diferent = requiredSum - i;
            if (exitstant.Contains(diferent))
            {
                return true;
            }
            exitstant.Add(i);
        }
        return false;
    }

}
