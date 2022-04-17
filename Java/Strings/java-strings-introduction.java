import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        String A = sc.next();
        String B = sc.next();
        
        System.out.printf("%d\n", (A.length() + B.length()));
        System.out.println(A.compareTo(B) > 0 ? "Yes" : "No");
        System.out.printf("%s %s", Character.toUpperCase(A.charAt(0)) + A.substring(1), Character.toUpperCase(B.charAt(0)) + B.substring(1));
    }
}



