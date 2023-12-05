namespace C_study;

public class StarPyramid
{
    public void GeneratePyramid() {
        Console.Write("How tall is the pyramid?: ");
            int num = Convert.ToInt32(Console.ReadLine());

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
