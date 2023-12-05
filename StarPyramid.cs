namespace C_study;

public class StarPyramid
{
    public void GeneratePyramid() {
        Console.Write("How tall is the pyramid?: ");
            string? input = Console.ReadLine();
            int? num = input?.Length > 0 ? int.Parse(input) : null;

            for (int row = 0; row <= num; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
    }
}
