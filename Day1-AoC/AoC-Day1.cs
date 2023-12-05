namespace C_study;

public class AoC_Day1
{
    public void Trebuchet() {
        string text = "jW21Aj)h;b*5cg&79g$S34";
        int sum = 0;

        foreach (char item in text)
        {
            if (char.IsDigit(item))
            {
                int num = item - '0';
                sum += num;
            }
        }

        Console.WriteLine(sum);
    }
}
