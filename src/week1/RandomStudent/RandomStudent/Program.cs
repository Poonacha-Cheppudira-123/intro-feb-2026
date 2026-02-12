// Random Student Picker
Console.Write("How many students are in the course? ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int studentCount) || studentCount <= 0)
{
    Console.WriteLine("Please enter a valid positive number.");
    return;
}

// Create a list of student numbers (1 to studentCount)
List<int> students = new List<int>();
for (int i = 1; i <= studentCount; i++)
{
    students.Add(i);
}

// Shuffle the list using Fisher-Yates algorithm
Random random = new Random();
for (int i = students.Count - 1; i > 0; i--)
{
    int j = random.Next(i + 1);
    int temp = students[i];
    students[i] = students[j];
    students[j] = temp;
}

// Display students one at a time
Console.WriteLine("\nPress Enter to select the next student...");
foreach (int studentNumber in students)
{
    Console.ReadLine();
    Console.WriteLine($"Student #{studentNumber}");
}

Console.WriteLine("\nAll students have been selected!");
