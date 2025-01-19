public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    /// 
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
        Console.WriteLine("Hello");
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> values1 = [];
        for (int divisor1 = 1; divisor1 < number; divisor1++){
            if (number % divisor1 == 0) {
                values1.Add(number/divisor1);
            }
            
            //Console.WriteLine(values1);
        }
        List<int> results = new(values1);

        // TODO problem 1
        return results;
    }
}