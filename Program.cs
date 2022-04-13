// Задача 3. Напишите программу, которая определяет является ли введеное число четным или нет.
Console.Clear(); // Clear the console berofe starting.
Console.WriteLine("This program checks your integer number for parity.");
Console.WriteLine("Please ender your integer number for checking:");
int Number=Convert.ToInt32(Console.ReadLine()); //Enter number for checking
int Result=Number % 2; // auxiliary variable is used to hold the result of our check
if (Result==0)
{
    Console.WriteLine("The entered number is even.");
}
else if (Result==1){ 
    Console.WriteLine("The entered number is odd."); 
}
else
{

}