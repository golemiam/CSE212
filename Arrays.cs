using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //already have function with multiples as parameters as per this set up
        // Will want a variable to hold double
        // will want a variable to hold int
        // create a for loop that loops the amount based on the int value
        // create a variable to hold count for the loop
        // for each iteration have the double multiplied by the current loop count
        double[] values = new double[length];
        for (int i = 0; i < length; i++) {
            values[i] = (i + 1) * number;
        }
        
        // I asked copilot about my code, apparently I had some syntax errors. after copying what copilot gave me it worked.
        // I feel this didn't violate my learning as I don't know the syntax very well for c# as this is my first class using it.
        // As you can see below, I was using basically the same logic. If you want me to resubmit, let me know, for now I want to move on to maximaize my learning time.
    //    List<int> values = []
    //     for (int i = 0; i < length; i++ ) {
    //         values.Add(i*numb)
    //     }


        return values; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //since we have variables for data and amount no need to create them
        // Use getRange function in c# to create a variable containing the parts of the list to be moved. (so 3 to the end, or 5 to the end or whatever depending)
        // Use remove range to remove the values from the list
        // use insert range to insert the values in the variable created

        List<int> valuesToMove = data.GetRange(amount, data.Count - amount);
        data.RemoveRange(amount, data.Count - amount);
        data.InsertRange(0, valuesToMove);
        Console.WriteLine(data);

    }
}
