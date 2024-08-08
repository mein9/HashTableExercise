using System.Collections;

namespace HashTableExercise
{
    internal class Program
    {

        public static void Main()
        {
            // Step 1: Create a Hashtable to store student IDs and grades
            Hashtable studentGrades = new Hashtable();

            // Step 2: Add several student IDs and grades to the Hashtable
            studentGrades.Add("A001", 85);  // Student ID: A001, Grade: 85
            studentGrades.Add("A002", 92);  // Student ID: A002, Grade: 92
            studentGrades.Add("A003", 78);  // Student ID: A003, Grade: 78
            studentGrades.Add("A004", 90);  // Student ID: A004, Grade: 90

            // Step 3: Retrieve and display the grade for a specific student
            string studentIdToRetrieve = "A002";
            if (studentGrades.ContainsKey("A002"))
            {
                Console.WriteLine($"Grade for student {studentIdToRetrieve}: {studentGrades[studentIdToRetrieve]}");
            }
            else
            {
                Console.WriteLine($"Student ID {studentIdToRetrieve} not found.");
            }

            Console.WriteLine("\nAll student grades and their hash codes:");
            foreach (DictionaryEntry entry in studentGrades)
            {
                string studentId = (string)entry.Key;
                int grade = (int)entry.Value;
                int hashCode = studentId.GetHashCode();

                Console.WriteLine($"Student ID: {studentId}, Grade: {grade}, Hash Code: {hashCode}");
            }
        }
    }
}
