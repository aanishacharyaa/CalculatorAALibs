using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class ExpressionEvaluatorTests
    {
        private class TestScenario
        {
            public string Expression { get; set; }
            public double ExpectedResult { get; set; }
        }

        private TestScenario[] TestScenarios = new TestScenario[]
        {
            new TestScenario { Expression = "2 + 3", ExpectedResult = 5 },
            new TestScenario { Expression = "7 - 4", ExpectedResult = 3 },
            new TestScenario { Expression = "5 * 6", ExpectedResult = 30 },
            new TestScenario { Expression = "15 / 3", ExpectedResult = 5 },
            new TestScenario { Expression = "(2 + 3) * 4 - 6 / 2", ExpectedResult = 17 },
            // Add more scenarios
        };

        [TestMethod]
        public void TestExpressions()
        {
            foreach (var scenario in TestScenarios)
            {
                double result = ExpressionEvaluator.EvaluateExpression(scenario.Expression);
                Assert.AreEqual(scenario.ExpectedResult, result);
            }
        }

        [TestMethod]
        public void TestInvalidExpression()
        {
            string expression = "invalid expression";
            Assert.ThrowsException<ArgumentException>(() => ExpressionEvaluator.EvaluateExpression(expression));
        }
    }
}
