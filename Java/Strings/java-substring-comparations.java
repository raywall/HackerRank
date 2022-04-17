import java.util.Scanner;

public class Solution {

    public static String getSmallestAndLargest(String s, int k) {
        String smallest = s.substring(0, k);
        String largest = s.substring(0, k);
        
        int
            i = 0, 
            j = 0;
        
        for (i = 0, j = i + k; i <= s.length() - k; i++, j = i + k)
        {
            String tmp = s.substring(i, j);
            
            if (smallest.compareTo(tmp) > 0)
                smallest = tmp;
                
            if (largest.compareTo(tmp) < 0)
                largest = tmp;
        }
        
        return smallest + "\n" + largest;
    }

