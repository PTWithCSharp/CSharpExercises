namespace Section1._3
{
    internal class EvaluateExpression
    {
        public static void Main(string[] args)
        {
            Stack<string> operations = new Stack<string>();
            Stack<double> operands = new Stack<double>();
            string input = Console.ReadLine();

            int index = 0;
            while (index < input.Length)

            {
                string current = input[index].ToString();
                if (char.IsWhiteSpace(input[index]))
                {
                    index++;
                    continue;
                }

                else if ("+-*/".Contains(current))
                {

                    operations.Push(current);
                    index++;
                    continue;

                }
                else if (current == "(")
                {
                    index++;
                    continue;
                }

                else if (current == ")")
                {
                    if (operations.Count == 0 || operands.Count <= 1)
                    {
                        Console.WriteLine("Invalid Expressions1");
                        return;
                    }

                    string NextOperation = operations.Pop();
                    double NextValue = operands.Pop();

                    switch (NextOperation)
                    {
                        case "+":
                            NextValue += operands.Pop();
                            break;
                        case "-":
                            NextValue = operands.Pop() - NextValue;
                            break;
                        case "*":
                            NextValue *= operands.Pop();
                            break;
                        case "/":
                            double divisor = NextValue;
                            if (divisor == 0)
                            {
                                Console.WriteLine("Error devided by 0");
                                return;
                            }

                            NextValue = operands.Pop() / NextValue;
                            break;
                        case "sqrt":
                            if (NextValue < 0)
                            {
                                Console.WriteLine("Square Root of Negative number");
                                return;
                            }
                            NextValue = Math.Sqrt(NextValue);
                            break;


                    }
                    operands.Push(NextValue);



                }
                else if (char.IsDigit(input[index]))
                {

                    int startNumberIndex = index;
                    bool hasFloatingPoint = false;
                    while (char.IsDigit(input[index]) || input[index] == '.')
                    {
                        if (hasFloatingPoint)
                        {
                            Console.WriteLine("Invalid Expression: Have one more floating point");
                            return;
                        }
                        if (input[index] == '.')
                        {
                            hasFloatingPoint = true;
                        }
                        index++;
                    }
                    double parsedNumber;
                    double.TryParse(input.Substring(startNumberIndex, index - startNumberIndex), out parsedNumber);
                    operands.Push(parsedNumber);
                }
                else if (input.Substring(index).StartsWith("sqrt"))
                {
                    operations.Push("sqrt");
                    index += 4;
                }
                else
                {
                    Console.WriteLine("Invalid Token");
                    return;
                }
            }
            if (operands.Count == 1)
            {
                Console.WriteLine($"Result is {operands.Pop()}");
            }
            else Console.WriteLine("Invalid Expression");

        }
    }
}