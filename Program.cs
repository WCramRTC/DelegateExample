using System.Reflection.Metadata.Ecma335;

namespace DelegateExample;

class Program
{
    public delegate double MathOperation(int a, int b);

    static void Main(string[] args)
    {
        MathOperation mathOperation = new MathOperation(Add);

        double AddValues = mathOperation(100, 22);

        System.Console.WriteLine(AddValues);

        mathOperation = (a,b) => a -b;

        System.Console.WriteLine(mathOperation(100,22)); 

        // MathOperation mo = new MathOperation(Add);
        // // Function - Return type and large number of arguments
        // // Action
        // // Predicate
        
        // Func<double, double, double> mathOp2 = (a,b)=> a * b; 
        // Action errors = () => {
        //     System.Console.WriteLine("This works");
        // };


        // DisplayError(errors);

        // errors = () => {
        //     System.Console.WriteLine("Null exception");
        // };

        // DisplayError(errors);


        // DisplayResult(mathOp2, 1, 2);

        // DisplayResult(mo,1 ,2);

        // mo = (a, b) => a-b;

        // DisplayResult(mo, 1,2);

    }    

    public static void DisplayError(Action errorMessage) {
        errorMessage();
    }

    public static void DisplayResult(Func<double, double, double> mo, int n1, int n2) {
        System.Console.WriteLine(mo(n1,n2));
    }

    public static double Add(int number1, int number2) {
        return number1 + number2;
    }

}
