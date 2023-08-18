using System;
using System.Data;

namespace CalculatorLib
{
    public class ExpressionEvaluator
    {
        public static double EvaluateExpression(string expression)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(expression, null);

                if (result is int || result is long || result is double || result is decimal)
                {
                    return Convert.ToDouble(result);
                }
                else
                {
                    throw new ArgumentException("Invalid result type");
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid expression");
            }
        }
    }
}
