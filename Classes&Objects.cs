namespace C_study;

public class CoB
{
    public void ClassesTry() {
        Book.title = "Diary of the Wimpy Kid";
        Book.author = "John";
        Book.pages = 300;
        Book.Intro(Book.title);
    }
}

public static class Book
{
    public static string? title;
    public static string? author;
    public static int pages;

    public static void Intro(string title) {
        Console.WriteLine($"This is a book titled {title}");
    }
}
