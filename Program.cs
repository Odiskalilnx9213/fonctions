using System;

class Calculator
{
   public static float Add(float a, float b)
   {
      return a + b;
   }

   public static float Subtract(float a, float b)
   {
      return a - b;
   }

   public static float Multiply(float a, float b)
   {
      return a * b;
   }

   public static float Divide(float a, float b)
   {
      if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
      return a / b;
   }

   public static int Modulo(int a, int b)
   {
      return a % b;
   }

   public static void Main()
   {
      while (true)
      {
         Console.WriteLine("Enter the first operand:");
         float firstOperand = float.Parse(Console.ReadLine());
         Console.WriteLine("Enter the second operand:");
         float secondOperand = float.Parse(Console.ReadLine());
         Console.WriteLine("Which operation you choose: add, subtract, multiply, divide, modulo");
         string operation = Console.ReadLine().ToLower();

         try
         {
            switch (operation)
            {
               case "add":
                  Console.WriteLine($"{firstOperand} + {secondOperand} = {Add(firstOperand, secondOperand)}");
                  break;
               case "subtract":
                  Console.WriteLine($"{firstOperand} - {secondOperand} = {Subtract(firstOperand, secondOperand)}");
                  break;
               case "multiply":
                  Console.WriteLine($"{firstOperand} x {secondOperand} = {Multiply(firstOperand, secondOperand)}");
                  break;
               case "divide":
                  Console.WriteLine($"{firstOperand} / {secondOperand} = {Divide(firstOperand, secondOperand)}");
                  break;
               case "modulo":
                  // Cast operands to int for modulo operation
                  Console.WriteLine($"{(int)firstOperand} % {(int)secondOperand} = {Modulo((int)firstOperand, (int)secondOperand)}");
                  break;
               default:
                  Console.WriteLine("Unknown operation");
                  break;
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }

         Console.WriteLine("Do you want to perform another operation? (yes/no)");
         if (Console.ReadLine().ToLower() != "yes") break;
      }
   }
}

