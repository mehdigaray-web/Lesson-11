// task 1 and 5:
//public delegate bool NumberCheckDelegate(int number);

//class Program
//{
//    static List<int> FilterNumbers(List<int> numbers, NumberCheckDelegate check)
//    {
//        List<int> result = new List<int>();
//        foreach (int n in numbers)
//        {
//            if (check(n)) result.Add(n);
//        }
//        return result;
//    }

//    static List<int> FilterWithPredicate(List<int> numbers, Predicate<int> check)
//    {
//        List<int> result = new List<int>();
//        foreach (int n in numbers)
//        {
//            if (check(n)) result.Add(n);
//        }
//        return result;
//    }

//    static void Main()
//    {
//        List<int> numbers = new List<int> { -50, -10, 3, 8, 45, 105, 200 };

//        Console.WriteLine("--- TASK 1: Custom Delegate ---");
//        Console.WriteLine($"Even: {string.Join(", ", FilterNumbers(numbers, n => n % 2 == 0))}");
//        Console.WriteLine($"Odd: {string.Join(", ", FilterNumbers(numbers, n => n % 2 != 0))}");
//        Console.WriteLine($"Positive: {string.Join(", ", FilterNumbers(numbers, n => n > 0))}");
//        Console.WriteLine($"Negative: {string.Join(", ", FilterNumbers(numbers, n => n < 0))}");
//        Console.WriteLine($"> 100: {string.Join(", ", FilterNumbers(numbers, n => n > 100))}");

//        Console.WriteLine("\n--- TASK 5: Predicate<T> ---");
//        Console.WriteLine($"Even: {string.Join(", ", FilterWithPredicate(numbers, n => n % 2 == 0))}");
//        Console.WriteLine($"Odd: {string.Join(", ", FilterWithPredicate(numbers, n => n % 2 != 0))}");
//        Console.WriteLine($"Positive: {string.Join(", ", FilterWithPredicate(numbers, n => n > 0))}");
//        Console.WriteLine($"Negative: {string.Join(", ", FilterWithPredicate(numbers, n => n < 0))}");
//        Console.WriteLine($"> 100: {string.Join(", ", FilterWithPredicate(numbers, n => n > 100))}");

//        Console.ReadLine();
//    }
//}
//task 2:
//public delegate bool StringCheckDelegate(string text);

//class Program
//{
//    static List<string> FilterStrings(List<string> strings, StringCheckDelegate check)
//    {
//        List<string> result = new List<string>();
//        foreach (string s in strings)
//        {
//            if (check(s)) result.Add(s);
//        }
//        return result;
//    }

//    static void Main()
//    {
//        List<string> strings = new List<string> { "Apple", "Cat", "Hello World", "Item123", "Albatross" };

//        Console.WriteLine("--- TASK 2 ---");
//        Console.WriteLine($"Length > 5: {string.Join(", ", FilterStrings(strings, s => s.Length > 5))}");
//        Console.WriteLine($"Starts with A: {string.Join(", ", FilterStrings(strings, s => s.StartsWith("A")))}");
//        Console.WriteLine($"Contains digits: {string.Join(", ", FilterStrings(strings, s => s.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) >= 0))}");
//        Console.WriteLine($"Contains space: {string.Join(", ", FilterStrings(strings, s => s.Contains(" ")))}");

//        Console.ReadLine();
//    }
//}
//task 3 and 6:
//public delegate int NumberOperationDelegate(int number);

//class Program
//{
//    static List<int> ProcessNumbers(List<int> numbers, NumberOperationDelegate operation)
//    {
//        List<int> result = new List<int>();
//        foreach (int n in numbers)
//        {
//            result.Add(operation(n));
//        }
//        return result;
//    }

//    static List<int> ProcessWithFunc(List<int> numbers, Func<int, int> operation)
//    {
//        List<int> result = new List<int>();
//        foreach (int n in numbers)
//        {
//            result.Add(operation(n));
//        }
//        return result;
//    }

//    static void Main()
//    {
//        List<int> numbers = new List<int> { 2, 4, 6 };

//        Console.WriteLine("--- TASK 3: Custom Delegate ---");
//        Console.WriteLine($"Square: {string.Join(", ", ProcessNumbers(numbers, n => n * n))}");
//        Console.WriteLine($"Cube: {string.Join(", ", ProcessNumbers(numbers, n => n * n * n))}");
//        Console.WriteLine($"Plus 10: {string.Join(", ", ProcessNumbers(numbers, n => n + 10))}");
//        Console.WriteLine($"Minus 5: {string.Join(", ", ProcessNumbers(numbers, n => n - 5))}");

//        Console.WriteLine("\n--- TASK 6: Func<T, TResult> ---");
//        Console.WriteLine($"Square: {string.Join(", ", ProcessWithFunc(numbers, n => n * n))}");
//        Console.WriteLine($"Cube: {string.Join(", ", ProcessWithFunc(numbers, n => n * n * n))}");
//        Console.WriteLine($"Plus 10: {string.Join(", ", ProcessWithFunc(numbers, n => n + 10))}");
//        Console.WriteLine($"Minus 5: {string.Join(", ", ProcessWithFunc(numbers, n => n - 5))}");

//        Console.ReadLine();
//    }
//}
//task 4:
//public delegate bool StudentCheckDelegate(Student student);

//public class Student
//{
//    public string Name;
//    public int Age;
//    public double AverageScore;

//    public Student(string name, int age, double averageScore)
//    {
//        Name = name;
//        Age = age;
//        AverageScore = averageScore;
//    }

//    public override string ToString()
//    {
//        return $"{Name} (Age: {Age}, Score: {AverageScore})";
//    }
//}

//class Program
//{
//    static List<Student> FilterStudents(List<Student> students, StudentCheckDelegate check)
//    {
//        List<Student> result = new List<Student>();
//        foreach (Student s in students)
//        {
//            if (check(s)) result.Add(s);
//        }
//        return result;
//    }

//    static void Main()
//    {
//        List<Student> students = new List<Student>
//        {
//            new Student("Mike", 17, 85.5),
//            new Student("Anna", 21, 92.0),
//            new Student("John", 19, 98.5),
//            new Student("Sara", 22, 70.0)
//        };

//        Console.WriteLine("--- TASK 4 ---");

//        Console.WriteLine("Older than 18:");
//        FilterStudents(students, s => s.Age > 18).ForEach(s => Console.WriteLine(s.ToString()));

//        Console.WriteLine("\nYounger than 20:");
//        FilterStudents(students, s => s.Age < 20).ForEach(s => Console.WriteLine(s.ToString()));

//        Console.WriteLine("\nScore > 90:");
//        FilterStudents(students, s => s.AverageScore > 90).ForEach(s => Console.WriteLine(s.ToString()));

//        Console.WriteLine("\nExcellent (Score >= 95):");
//        FilterStudents(students, s => s.AverageScore >= 95).ForEach(s => Console.WriteLine(s.ToString()));

//        Console.ReadLine();
//    }
//}
