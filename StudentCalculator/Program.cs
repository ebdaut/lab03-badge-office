// top variable(s) used throughout the code
Random rng = new Random();
// part 1 - the name

System.Console.Write("Please provide your first and last name.");
string studentName = System.Console.ReadLine();
studentName = studentName.Trim();

int spacePosition = studentName.IndexOf(" ");
string firstName = studentName.Substring(0, spacePosition);
string lastName = studentName.Substring(spacePosition + 1);

System.Console.WriteLine($"Name on Badge: {studentName.ToUpper()}");
System.Console.WriteLine($"Username: {firstName.Substring(0,1).ToLower()}{lastName.ToLower()}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");

