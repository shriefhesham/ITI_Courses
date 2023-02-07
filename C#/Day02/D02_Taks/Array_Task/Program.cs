int Longest_distance()
{

    Console.Write("\n\n Enter Number Of Element In Array  :\t");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] arr1 = new int[N];

    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"Enter Element #{i+1} : ");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine(" Elemnts of Array  :\t  ");

    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write("  {0}  ", arr1[i]);
    }


    int longest_distance = 0;
    int Frist_value = 0;
    int Second_value = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = i + 1; j < arr1.Length; j++)
        {
            if (arr1[i] == arr1[j])
                Second_value = j;
                Frist_value = i;

            if (Second_value - Frist_value > longest_distance)
            {
                longest_distance = Second_value - Frist_value;
            }
        }
    }

    Console.WriteLine("\n\n longest Distance Between Two Elemnts \t  ");

    return longest_distance-1;
}


Console.WriteLine( Longest_distance());




// 7	0	0	0	5	6	7	5	0	7	5	3