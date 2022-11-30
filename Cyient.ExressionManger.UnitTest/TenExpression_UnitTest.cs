using Cyient.Common.Models;
using Cyient.Expressions;
using Cyient.Facade;

namespace Cyient.ExressionManger.UnitTest
{

    [TestClass]
    public class TenExpression_UnitTest
    {
        [TestMethod]
        public void TenExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new TenExpression();
            Context context = new Context(50);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("L", context.Output);
        }

        [TestMethod]
        public void TenExpression_NegativeTest()
        {
            /// Arrange 
            Expression expression = new TenExpression();
            Context context = new Context(50);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("LV", context.Output);
        }
    }
}
