/*
* Name: Ethan Daut
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: October 4, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

// top variable(s) used throughout the code

using Microsoft.VisualBasic;

Random rng = new Random();

// part 1 - the name - has the student provide their name, and then generates their first, last, and student username

System.Console.Write("Please provide your first and last name.");
string studentName = System.Console.ReadLine();
studentName = studentName.Trim();

int spacePosition = studentName.IndexOf(" ");
string firstName = studentName.Substring(0, spacePosition);
string lastName = studentName.Substring(spacePosition + 1);
string userName = firstName.Substring(0,1).ToLower()+lastName.ToLower();

// part 2 - the numbers, generates a random number for the student ID and their locker number

int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

// part 3 - the walk - gets the position of the class, dorm, and the students walking speed to calculate how long

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
// average human walkspeed is 4.4 feet per second

const int secondsPerMin = 60;

double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));

double walkingTime = distance / walkSpeed;
int walkingMins = Convert.ToInt16(walkingTime / secondsPerMin);
int walkingSecs = Convert.ToInt16(walkingTime % secondsPerMin);

// part four - student ID

const int checkdigit = 9;

int check = studentID % checkdigit;
string studentIDcheck = studentID + "-" + check;

// output block - contains all of the code for the computer writing all of the blocks.

// part one output:

System.Console.WriteLine($"Name on Badge: {studentName.ToUpper()}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}\n");

// part two output:

System.Console.WriteLine($"StudentID: {studentID}");
System.Console.WriteLine($"Locker: {lockerNumber}\n");

// part three output:

System.Console.WriteLine($"DormX: {dormX.ToString("F1")}");
System.Console.WriteLine($"DormY: {dormY.ToString("F1")}");
System.Console.WriteLine($"ClassX: {classX.ToString("F1")}");
System.Console.WriteLine($"ClassY: {classY.ToString("F1")}");
System.Console.WriteLine($"Walking speed in feet per second: {walkSpeed.ToString("F1")}\n");
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