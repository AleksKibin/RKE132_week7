Console.WriteLine("Are you comng or leaving?");
string userChoise = Console.ReadLine();
if(userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

PrintHello(); 
PrintGoodBye();
static void PrintHello() //Function / method
{
    Console.WriteLine("Hello world!");
}
static void PrintGoodBye()
{
    Console.WriteLine("See ya later, alligator!");
}
