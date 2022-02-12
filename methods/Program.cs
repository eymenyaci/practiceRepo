using System;

namespace methods
{
    class program
    {

        static void Main(string[] args)
        {
           int result = sub(1,2);
           methods mtd = new methods();
           mtd.printTerminal(Convert.ToString(result));
           

        }
        static int sub(int x,int y)
        {
            return (x+y);
        }

    }

    class methods
    {
        public void printTerminal(string input)
        {
            Console.WriteLine(input);
        }
    }

}