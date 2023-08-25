import java.lang.*;


public class StaticBlock{
    public static int a;
    
   static {
        System.out.println("Static Executed");
        a=10;
    }

    public StaticBlock(){
        System.out.println("Constructor executed");
        System.out.println(a);
    }

}