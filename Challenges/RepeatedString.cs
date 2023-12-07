namespace C_study;

public class RepeatedString
{
    public void RepString() {
        Console.Write("Gimme some string: ");
        string? text = Console.ReadLine();
        Console.Write("Gimme some number: ");
        int times = Convert.ToInt32(Console.ReadLine());

        if (text == null) {
            Console.WriteLine("pls write something");
        } else {
            Console.WriteLine(Repeat(text, times));
        }


        static string Repeat(string txt, int num) {
            string repeatedText = "";

            for (int i = 0; i < num; i++)
            {
                repeatedText += txt;
            }
            return repeatedText;
        }
    }
}
