using Cyient.Common.Models;
using Cyient.Expressions;
using Cyient.Facade;

namespace Cyient.ExressionManger.UnitTest
{
    [TestClass]
    public class OneExpression_UnitTest
    {
        [TestMethod]
        public void OneExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new OneExpression();
            Context context = new Context(8);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("VIII", context.Output);
        }

        [TestMethod]
        public void OneExpression_NegativeTest()
        {
            /// Arrange 
            Expression expression = new OneExpression();
            Context context = new Context(8);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("V", context.Output);
        }
    }
}