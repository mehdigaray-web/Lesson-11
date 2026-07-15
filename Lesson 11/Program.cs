// Main 

int[] numbers = new int[] { -50, -10, 0, 3, 8, 15, 42, 77, 101, 200, -3, 56 };

PrintList("Even",        FilterNumbers(numbers, IsEven));
PrintList("Odd",         FilterNumbers(numbers, IsOdd));
PrintList("Positive",    FilterNumbers(numbers, IsPositive));
PrintList("Negative",    FilterNumbers(numbers, IsNegative));
PrintList("Over 100",    FilterNumbers(numbers, IsOver100));

Console.WriteLine();

string[] words = new string[]
{
    "Apple", "hi", "Android", "C# 12", "dog", "hello world",
    "Azerbaijan", "ok123", "yes", "Baku city", "A"
};

PrintStrings("Longer than 5",   FilterStrings(words, LongerThan5));
PrintStrings("Starts with A",   FilterStrings(words, StartsWithA));
PrintStrings("Contains digit",  FilterStrings(words, ContainsDigit));
PrintStrings("Contains space",  FilterStrings(words, ContainsSpace));

Console.WriteLine();

int[] baseNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

PrintList("Square",        TransformNumbers(baseNumbers, Square));
PrintList("Cube",          TransformNumbers(baseNumbers, Cube));
PrintList("Add 10",        TransformNumbers(baseNumbers, AddTen));
PrintList("Subtract 5",    TransformNumbers(baseNumbers, SubtractFive));

Console.WriteLine();

Student[] students = new Student[]
{
    new Student("Tural Mammadov",   17, 88),
    new Student("Aysel Hasanova",   19, 95),
    new Student("Rauf Guliyev",     20, 72),
    new Student("Nigar Aliyeva",    18, 97),
    new Student("Kamran Huseynov",  21, 91),
    new Student("Leyla Jafarova",   16, 60)
};

PrintStudents("Older than 18",    FilterStudents(students, OlderThan18));
PrintStudents("Younger than 20",  FilterStudents(students, YoungerThan20));
PrintStudents("Grade over 90",    FilterStudents(students, GradeOver90));
PrintStudents("Excellent (95+)",  FilterStudents(students, IsExcellent));

Console.WriteLine();

int[] nums = new int[] { -50, -10, 0, 3, 8, 15, 42, 77, 101, 200, -3, 56 };

Predicate<int> evenPredicate    = IsEven;
Predicate<int> oddPredicate     = IsOdd;
Predicate<int> posPredicate     = IsPositive;
Predicate<int> negPredicate     = IsNegative;
Predicate<int> over100Predicate = IsOver100;

PrintList("Even (Predicate)",     FilterWithPredicate(nums, evenPredicate));
PrintList("Odd (Predicate)",      FilterWithPredicate(nums, oddPredicate));
PrintList("Positive (Predicate)", FilterWithPredicate(nums, posPredicate));
PrintList("Negative (Predicate)", FilterWithPredicate(nums, negPredicate));
PrintList("Over 100 (Predicate)", FilterWithPredicate(nums, over100Predicate));

Console.WriteLine();

Func<int, int> squareFunc   = Square;
Func<int, int> cubeFunc     = Cube;
Func<int, int> addTenFunc   = AddTen;
Func<int, int> subFiveFunc  = SubtractFive;

int[] baseNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

PrintList("Square (Func)",      TransformWithFunc(baseNums, squareFunc));
PrintList("Cube (Func)",        TransformWithFunc(baseNums, cubeFunc));
PrintList("Add 10 (Func)",      TransformWithFunc(baseNums, addTenFunc));
PrintList("Subtract 5 (Func)",  TransformWithFunc(baseNums, subFiveFunc));

Console.WriteLine();

int[] lambdaNums = new int[] { -50, -10, 0, 3, 8, 15, 42, 77, 101, 200, -3, 56 };

PrintList("Even (lambda)",    FilterNumbers(lambdaNums, n => n % 2 == 0));
PrintList("Odd (lambda)",     FilterNumbers(lambdaNums, n => n % 2 != 0));
PrintList("Positive (lambda)",FilterNumbers(lambdaNums, n => n > 0));
PrintList("Negative (lambda)",FilterNumbers(lambdaNums, n => n < 0));
PrintList("Over 100 (lambda)",FilterNumbers(lambdaNums, n => n > 100));

Console.WriteLine();

int[] lambdaBase = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

PrintList("Square (lambda)",     TransformNumbers(lambdaBase, n => n * n));
PrintList("Cube (lambda)",       TransformNumbers(lambdaBase, n => n * n * n));
PrintList("Add 10 (lambda)",     TransformNumbers(lambdaBase, n => n + 10));
PrintList("Subtract 5 (lambda)", TransformNumbers(lambdaBase, n => n - 5));




delegate bool NumberCheck(int number);

static int[] FilterNumbers(int[] numbers, NumberCheck check)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (check(numbers[i])) count++;

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (check(numbers[i]))
            result[index++] = numbers[i];
    return result;
}

static bool IsEven(int n)      { return n % 2 == 0; }
static bool IsOdd(int n)       { return n % 2 != 0; }
static bool IsPositive(int n)  { return n > 0; }
static bool IsNegative(int n)  { return n < 0; }
static bool IsOver100(int n)   { return n > 100; }

static void PrintList(string label, int[] list)
{
    Console.Write(label + ": ");
    for (int i = 0; i < list.Length; i++)
        Console.Write(list[i] + " ");
    Console.WriteLine();
}

delegate bool StringCheck(string text);

static string[] FilterStrings(string[] items, StringCheck check)
{
    int count = 0;
    for (int i = 0; i < items.Length; i++)
        if (check(items[i])) count++;

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < items.Length; i++)
        if (check(items[i]))
            result[index++] = items[i];
    return result;
}

static bool LongerThan5(string s)    { return s.Length > 5; }
static bool StartsWithA(string s)    { return s.StartsWith("A"); }
static bool ContainsDigit(string s)
{
    for (int i = 0; i < s.Length; i++)
        if (char.IsDigit(s[i]))
            return true;
    return false;
}
static bool ContainsSpace(string s)  { return s.Contains(" "); }

static void PrintStrings(string label, string[] list)
{
    Console.Write(label + ": ");
    for (int i = 0; i < list.Length; i++)
        Console.Write("[" + list[i] + "] ");
    Console.WriteLine();
}

delegate int NumberOperation(int number);

static int[] TransformNumbers(int[] numbers, NumberOperation operation)
{
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
        result[i] = operation(numbers[i]);
    return result;
}

static int Square(int n)       { return n * n; }
static int Cube(int n)         { return n * n * n; }
static int AddTen(int n)       { return n + 10; }
static int SubtractFive(int n) { return n - 5; }

class Student
{
    public string Name;
    public int Age;
    public double Grade;

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

delegate bool StudentCheck(Student student);

static Student[] FilterStudents(Student[] students, StudentCheck check)
{
    int count = 0;
    for (int i = 0; i < students.Length; i++)
        if (check(students[i])) count++;

    Student[] result = new Student[count];
    int index = 0;
    for (int i = 0; i < students.Length; i++)
        if (check(students[i]))
            result[index++] = students[i];
    return result;
}

static bool OlderThan18(Student s)   { return s.Age > 18; }
static bool YoungerThan20(Student s) { return s.Age < 20; }
static bool GradeOver90(Student s)   { return s.Grade > 90; }
static bool IsExcellent(Student s)   { return s.Grade >= 95; }

static void PrintStudents(string label, Student[] list)
{
    Console.WriteLine(label + ":");
    for (int i = 0; i < list.Length; i++)
        Console.WriteLine("  " + list[i].Name + " | Age: " + list[i].Age + " | Grade: " + list[i].Grade);
}

static int[] FilterWithPredicate(int[] numbers, Predicate<int> predicate)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (predicate(numbers[i])) count++;

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (predicate(numbers[i]))
            result[index++] = numbers[i];
    return result;
}

static int[] TransformWithFunc(int[] numbers, Func<int, int> operation)
{
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
        result[i] = operation(numbers[i]);
    return result;
}
