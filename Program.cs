class Program
{
    static void Main()
    {

        int Iterations = 1000000000;

        decimal piApprox = 0;

        decimal coeff = +1;

        decimal currNum = 1;

        for (int i = 0; i < Iterations; i++)
        {
            piApprox += coeff * (1m / currNum);

            if (i % 1000000 == 0)
            {
                Console.Write("i[" + i + "]: += " + coeff + " * (1 / " + currNum + ")) * 4 = ");
                Console.WriteLine(piApprox * 4);
            }

            coeff = -coeff;

            currNum += 2;
        }

        Console.WriteLine("Pi[" + Iterations + "]: " + piApprox * 4);
        Console.ReadLine();
    }
}
