// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300021;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Dzulfikar");
        video.PrintVideoDetails();

        try
        {
            video.IncreasePlayCount(10000000); // batas akhir
            video.PrintVideoDetails();

            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(10000000); // Memicu overflow
            }

            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

