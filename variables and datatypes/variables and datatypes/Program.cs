//in such case where the value for the varaible isn't given then it will be the default value which is 0.
//sbyte is known as signed byte which can have whole numbers from -128 to 127
//sbyte doesn't need lot of storage it is of small size and stores a lil bit of data and also good if we hve to write high performance software
//Short  is another primitive datatype which can store whole numbers from  -32767 to 32767
//int can store whole numbers from -2147483648 to 2147483647
//if we need a very big number to store we use long which can store whole number from -9223327036854775808 to 9223327036854775807
//which one to use? use the smallest data type your values fit in..
//float primitive data type float x=10.9f f is require for c# to understand its a floating value if we dont add f then the compiler will think ts a double value and then it throws error
//double has higher precision than float 7 pre double ko 15 somewhat they are same ex: double x=1.5;
//decimal for higher precision that is up10 28 digit

//float is mostly used in   graphic libraries(high demands for processing powers)
//double is mostly used in real world values(except money calcumations)
//decimal is mostly used in financial applications (high level accuracy)
//bool
//char char love='a'; it uses single code {' '}
//String love="nija" ; it uses double code{" "}

namespace variables_and_datatypes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int age;//in such case there will be the default value of age which is 0.
            Console.WriteLine(age);
        }
    }
}
