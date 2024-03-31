public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name: ");
        string? name = Console.ReadLine();


        char[] charArray = name.ToCharArray(); //change string to char

        //Reverse 
        ReverseCharArray(charArray);

        Console.WriteLine("\nReversed array:");
        PrintCharArray(charArray);
    }

    static void ReverseCharArray(char[] array)
    {
        int start = 0;
        int j = array.Length - 1;

        while (start < j)
        {

            char temp = array[start];
            array[start] = array[j];
            array[j] = temp;

            start++;
            j--;
        }
    }
    static void PrintCharArray(char[] array) // accept reverse char in arr
    {
        foreach (char c in array)
        {
            Console.Write(c + " ");
        }
    }


}

