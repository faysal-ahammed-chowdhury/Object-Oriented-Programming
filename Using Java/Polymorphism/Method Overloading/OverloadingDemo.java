import java.lang.*;

public class OverloadingDemo {
    public void print() {
        System.out.println("Hello");
    }

    // overloading
    public void print(String s) {
        System.out.println("Hello, " + s);
    }

    public static void main(String[] args) {
        OverloadingDemo od = new OverloadingDemo();
        od.print();
        od.print("Faysal");
    }
}
