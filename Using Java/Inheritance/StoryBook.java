import java.lang.*;

class StoryBook extends Book {
    private String category;
    private static double discountRate;

    public StoryBook() {
        System.out.println("Story Book Empty Constructor");
    }

    public StoryBook(String isbn, String bookTitle, String authorName, double price, int availableQuantity, String category) {
        super(isbn,bookTitle,authorName,price,availableQuantity);
        System.out.println("Story Book Parameterized Constructor");
        this.category = category;
    }

    public static void setDiscountRate(double rate) {
        discountRate = rate;
    }

    public static double getDiscountRate() {
        return discountRate;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    public String getCategory() {
        return category;
    }

    public void showDetails() {
        super.showDetails();
        System.out.println("Category: "+category);
        System.out.println("Discount Rate: "+discountRate);
    }
}