using Cyient.Common.Models;
using Cyient.Expressions;
using Cyient.Facade;

namespace Cyient.ExressionManger.UnitTest
{
    [TestClass]
    public class ThousandExpression_UnitTest
    {
        [TestMethod]
        public void ThousandExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new ThousandExpression();
            Context context = new Context(2000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("MM", context.Output);
        }

        [TestMethod]
        public void ThousandExpression_NegativeTest()
        {
            /// Arrange 
            Expression expression = new ThousandExpression();
            Context context = new Context(2000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("VIII", context.Output);
        }
    }
}
