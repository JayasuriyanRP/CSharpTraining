namespace CalculatorLibrary
{
    /// <summary>
    /// class containing methods for calculation such as: addition, subtraction, multiplication and division
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// method to add any two integer type numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second number</param>
        /// <returns>
        /// returns result of addition of two numbers
        /// </returns>
        public static int Add(int firstNumber, int secondNumber)
        {
            int addResult = firstNumber + secondNumber;
            return addResult;
        }

        /// <summary>
        /// method to subtract an integer type number from another
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second number</param>
        /// <returns>
        /// returns result of subtraction of two numbers
        /// </returns>
        public static int Subtract(int firstNumber, int secondNumber)
        {
            int subtractResult = firstNumber - secondNumber;
            return subtractResult;
        }

        /// <summary>
        /// method to multiply any two integer type numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second number</param>
        /// <returns>
        /// returns result of multiplication of two numbers
        /// </returns>
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int multiplicationResult = firstNumber * secondNumber;
            return multiplicationResult;
        }

        /// <summary>
        /// method to divide an integer type number by another
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second number</param>
        /// <returns>
        /// returns result of division of two numbers
        /// </returns>
        public static int Divide(int firstNumber, int secondNumber)
        {
            int divisionResult = firstNumber / secondNumber;
            return divisionResult;
        }
    }
}
