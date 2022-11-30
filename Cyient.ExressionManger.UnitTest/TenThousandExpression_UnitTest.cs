using Cyient.Common.Models;
using Cyient.Expressions;
using Cyient.Facade;

namespace Cyient.ExressionManger.UnitTest
{
    [TestClass]
    public class TenThousandExpression_UnitTest
    {
        [TestMethod]
        public void TenThousandExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new TenThousandExpression();
            Context context = new Context(30000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("xxx", context.Output);
        }

        [TestMethod]
        public void TenThousandExpression_NegativeTest()
        {
            /// Arrange 
            Expression expression = new TenThousandExpression();
            Context context = new Context(20000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("VIII", context.Output);
        }
    }
}
