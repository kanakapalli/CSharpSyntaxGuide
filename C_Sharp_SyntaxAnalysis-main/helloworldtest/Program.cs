
using CsharpDemo;

class Program
{
    static void Main(string[] arg)
    {
        Log("DataTypes.Demo", DataTypes.Demo);
        Log(" Operators.Demo()",  Operators.Demo);
        Log("Logging.Demo", Logging.Demo);
        Log("CollectionExplanations.Demo", CollectionExplanations.Demo);
        
    }

private    static void Log(string name, Action logAction)
        {
            Console.WriteLine("==============================================================================");
            Console.WriteLine($"================================ {name} ================================");
            Console.WriteLine("==============================================================================");
            logAction();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("==============================================================================");

        }
        

}


 

