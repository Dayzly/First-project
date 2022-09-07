using System;
class program
{
    static void Main()
    {
        //int[] numbers = new int[5];

        //numbers[0] = 3;
        //numbers[1] = 4;
        //numbers[2] = 6;
        //numbers[3] = 20;
        //numbers[4] = 100;

        //int[] djob1 = new int[] { 5, 10, 20, 50, 100, 1 };

        //string[] textArray = new string[] { "Purva", "Vtori", "Treti", "Chetvuri", };

        //  Console.WriteLine(djob1[2]);


        //ReversedArray Example

        Console.WriteLine("Plese give me the size ot the array");
        int length = int.Parse(Console.ReadLine());
        int []array = new int[length]; 
        
        //filling the original array
        for(int i = 0; i < length; i++)
        {
            Console.WriteLine("Give me number for index: " + i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 1, 2, 3, 4, 5};
        //int lenght = array.Length;
        int []Reversed = new int[length];
        //reverse the array
        for (int i = 0; i < length; i++)
        {
            int currElement=array[i];
            Reversed[length - 1] = currElement;

        }
        //Printing the reversed array
        for (int i = 0;i < length; i++)
        {
            Console.Write($"Is the array symetric?");
        }





    }
}
