import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int line = 0;
        
        while (true)
        {
            if (!scanner.hasNext())
                break;
    
            String message = scanner.nextLine();
            System.out.println(String.format("%1$d %2$s", ++line, message));
        }
        
        scanner.close();
    }
}
