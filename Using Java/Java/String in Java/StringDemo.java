import java.lang.*;

public class StringDemo{
    public static void main(String[] args){
        String s1 = "Hello"; // String literal
        String s2 = "Hello";
        String s3= new String("Hello");
        String s4 = "Hello";
        String s5= new String("Hello");
        // System.out.println("S1: "+s1);
        // System.out.println("S2: "+s2);
        // System.out.println("S3: "+s3);
        // System.out.println(s1==s2);
        // System.out.println(s1==s3);

        System.out.println(s1.length());
        System.out.println(s1.charAt(1));
        System.out.println(s1.equals(s3));
        System.out.println(s1.indexOf('i'));
        System.out.println(s1.substring(1,3));
        System.out.println(s1.toUpperCase());
        System.out.println(s1.toLowerCase());
    }
}