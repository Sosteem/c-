using System;//this means it wants to use system which has bunch of differenr classes different functionality we can use for example console
//namespace email //this gives  bunch of classes to send emails

namespace helloworld//helloworld is our own namespace
{//this is body and the class program is inside the namespace helloworld
    internal class Program//own class called program
    {
        static void Main(string[] args)//entry point of any program
            //helps us to understand whats happening in the code
            //static means we don't need to create an object to run the void main method
            //console.writeline is inside the void main method.
        {
            Console.WriteLine("Hello World!");
            //writeline is its own method which writes in the console which is the method of system and namespaces
            Console.WriteLine("Hello Swastika!!");
            Console.Read();//it helps not to close the console faster
        }
    }
}
