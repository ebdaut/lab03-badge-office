// top variable(s) used throughout the code

using Microsoft.VisualBasic;

Random rng = new Random();

// part 1 - the name

System.Console.Write("Please provide your first and last name.");
string studentName = System.Console.ReadLine();
studentName = studentName.Trim();

int spacePosition = studentName.IndexOf(" ");
string firstName = studentName.Substring(0, spacePosition);
string lastName = studentName.Substring(spacePosition + 1);
string userName = firstName.Substring(0,1).ToLower()+lastName.ToLower();

// part 2 - the numbers

int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

// part 3 - the walk

System.Console.WriteLine("Please provide the X number for your dorm.");
double dormX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Please provide the Y number for your dorm.");
double dormY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Please provide the X number for your class.");
double classX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Please provide the Y number for your class.");
double classY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Please provide your walking speed in feet per second.");
double walkSpeed = Convert.ToDouble(Console.ReadLine());
// average is 4.4

const int secondsPerMin = 60;

double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));

double walkingTime = distance / walkSpeed;
int walkingMins = Convert.ToInt16(walkingTime / secondsPerMin);
int walkingSecs = Convert.ToInt16(walkingTime % secondsPerMin);

// part four - student ID

const int checkdigit = 9;

int check = studentID % checkdigit;
string studentIDcheck = studentID + "-" + check;

// output block

// part one output:

System.Console.WriteLine($"Name on Badge: {studentName.ToUpper()}");
//System.Console.WriteLine($"Username: {firstName.Substring(0,1).ToLower()}{lastName.ToLower()}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}\n");

// part two output:

System.Console.WriteLine($"StudentID: {studentID}");
System.Console.WriteLine($"Locker: {lockerNumber}\n");

// part three output:

System.Console.WriteLine($"Distance: {distance.ToString("F1")} feet");
System.Console.WriteLine($"Walk Time: {walkingMins} Minute(s) & {walkingSecs} Seconds. \n");

// part four output:

System.Console.WriteLine("==================================\n        ETSU STUDENT BADGE          \n==================================");
System.Console.WriteLine("NAME".PadRight(10) + $"{studentName.ToUpper()}");
System.Console.WriteLine("USERNAME".PadRight(10) + $"{userName}");
System.Console.WriteLine("ID".PadRight(10) + $"{studentIDcheck}");
System.Console.WriteLine("LOCKER".PadRight(10) + $"{lockerNumber}");
System.Console.WriteLine("WALK".PadRight(10) + $"{walkingMins} min {walkingSecs} sec");
System.Console.WriteLine("==================================");

