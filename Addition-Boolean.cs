using System;

class IntegerSum{
    public static void Main(string[] args){
        int num1;
        int num2;

        Console.Write("Enter 1st Integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd Integer: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 == 30 || num2 == 30 || num1 + num2 == 30){
            Console.Write("True");
        }
        else{
            Console.Write("False");
        }
    }
}