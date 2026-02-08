using System;
class Pro
{
    static void Main()
    {
        int[] arr = new int [8];
        Console.WriteLine("enter numbers (8) :");
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            bool alreadychecked = false;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j] )
                {
                    alreadychecked = true;
                    break;
                }
            }
            if (alreadychecked)
                continue;
            int count = 0;
            for (int j = 0; j < 6; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
               
            }
            Console.WriteLine(arr[i]+" appears "+count+" times.");
        }
    }
}