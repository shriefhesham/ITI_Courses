
using System.Diagnostics;

void numofones_1()
{
    int count = 0;
    var stopwatch = new System.Diagnostics.Stopwatch();
    stopwatch.Start();
    for (int i = 1; i <= 99_999_999; i++)
    {
        int j = i;
        while (j != 0)
        {
            if (j % 10 == 1)
                count++ ;
            j /= 10 ;
        }
    }
    stopwatch.Stop();
    Console.WriteLine($"Number of One's by Numaric way : {count} , Time : {stopwatch.Elapsed}") ;
}

void numOfOnes_2()
{
    int count = 0;
    string one = "";
    var stopwatch = new System.Diagnostics.Stopwatch();
    stopwatch.Start();
    for (int i = 0; i < 99999999; i++)
    {
        one = Convert.ToString(i);
        foreach (char j in one)
        {
            if (j == '1')
            {
                count++;
            }
        }
    }
    stopwatch.Stop();
    Console.WriteLine($"Number of One's by String way : {count} Time : {stopwatch.Elapsed}" );
}

void numOfOnes_3()
{
    var stopwatch = new System.Diagnostics.Stopwatch();
    stopwatch.Start();
    int n = 8, counter = 0;
    counter = (int)(n * Math.Pow(10, n - 1));
    stopwatch.Stop();
    Console.WriteLine($"Number of One's by Math way : {counter} Time : {stopwatch.Elapsed}");
}


//numofones_1();
numOfOnes_2();
//numOfOnes_3();

