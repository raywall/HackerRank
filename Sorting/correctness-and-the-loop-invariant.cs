using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution { 
    public static void insertionSort (int[] arr) { 
        int
            a = 0,
            b = 0; 
        
        for (a = 0, b = a + 1; b < arr.Length; a++, b++) 
        { 
            var value = arr[b];
            int i = a;
            
            while (i >= 0 && value < arr[i])
                arr[i + 1] = arr[i--];
            
            arr[i + 1] = value; 
        } 
        
        Console.WriteLine(string.Join(" ", arr)); 
    }

    static void Main(string[] args) { 
        Console.ReadLine(); 
        int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar); 
    }
}

