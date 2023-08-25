import java.lang.*;

class TextBook extends Book {
    private int standard;
    private static double discountRate;

    public TextBook() {
        System.out.println("Text Book Empty Constructor");
    }

    public TextBook(String isbn, String bookTitle, String authorName, double price, int availableQuantity, int standard) {
        super(isbn,bookTitle,authorName,price,availableQuantity);
        System.out.println("Text Book Parameterized Constructor");
        this.standard = standard;
    }

    public static void setDiscountRate(double rate) {
        discountRate = rate;
    }

    public static double getDiscountRate() {
        return discountRate;
    }

    public void setStandard(int standard) {
        this.standard = standard;
    }

    public int getStandard() {
        return standard;
    }

    public void showDetails() {
        super.showDetails();
        System.out.println("Standard: "+standard);
        System.out.println("Discount Rate: "+discountRate);
    }
}