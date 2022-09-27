using System;
namespace Empp;
class Em
{
    static void Main(string[] args)
    {
        int FULLTIME = 1; 
        Random random =new Random();
        int Empchk = random.Next(0, 2);
        if(Empchk == FULLTIME)
        {
            Console.Write("EMPLOYEE IS PRESENT");
        }
        else
        {
            Console.Write("EMPLOYEE IS ABSENT");
        }
    }
}