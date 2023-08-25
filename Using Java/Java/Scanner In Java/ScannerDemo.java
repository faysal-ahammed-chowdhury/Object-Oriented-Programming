import java.lang.*;
import java.util.Scanner;

public class ScannerDemo{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        String s = in.nextLine();
        System.out.println(a);
        System.out.println(s);

    }
}