using System;

namespace calculatorApp
{
    class calculator
    {
        static void Main(string[] args)
        {
            List<char> digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<char> operations = new List<char> { 'x', '+', '-', '/' };
            char wantedOperation = ' ';
            List<char> userOperationDigits = new List<char> {};
            List<char> num1List = new List<char> {};
            List<char> num2List = new List<char> {};

            Console.WriteLine("Welcome to the simple but a bit advanced calculator (because you type the operation), please type your operation");
            Console.WriteLine("Keep in mind, this calculator does operations of 2 numbers only, thank you.");
            string? userOperation = Console.ReadLine();
            while (userOperation == null || userOperation == string.Empty){
                Console.WriteLine("You didn't write anything, your operation :");
                userOperation = Console.ReadLine();
            }
            for (int i = 0; i < userOperation.Length; i++)
            {
                if (digits.Contains(userOperation[i])){
                    num1List.Add(userOperation[i]);
                }
                if (operations.Contains(userOperation[i])){
                    wantedOperation = userOperation[i];
                    break;
                }
            }
            for (int i = 0; i < userOperation.Length; i++)
            {
                if (operations.Contains(userOperation[i])){
                    for (int j = i + 1; j < userOperation.Length; j++){
                        if(userOperation[j] == ' '){
                            continue;
                        }
                        num2List.Add(userOperation[j]);
                    }
                }
            }
            int num1 = 0;
            int num2 = 0;
            try{
                num1 = Convert.ToInt32(String.Join("", num1List));
                num2 = Convert.ToInt32(String.Join("", num2List));
            }
            catch(Exception){
                Console.WriteLine("Something went wrong, (mostly numbers conversion error, make sure you wrote valid numbers and operation symbols)");
            }
            if(wantedOperation == '/' && num2 == 0){
                Console.WriteLine("Cannot divide by zero");
            }
            switch(wantedOperation){
                case 'x': Console.WriteLine($"The result is : {num1 * num2}");
                break;
                case '+': Console.WriteLine($"The result is : {num1 + num2}");
                break;
                case '-': Console.WriteLine($"The result is : {num1 - num2}");
                break;
                case '/': Console.WriteLine($"The result is : {num1 / num2}");
                break;
                default: Console.WriteLine("Invalid Operation");
                break;
            }
        }
    }
}