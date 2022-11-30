using Cyient.Common.Models;
using Cyient.Expressions;
using Cyient.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyient.ExressionManger.UnitTest
{
    [TestClass]
    public class MillionExpression_UnitTest
    {
        [TestMethod]
        public void MillionExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new MillionExpression();
            Context context = new Context(1000000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("m", context.Output);
        }

        [TestMethod]
        public void MillionExpression_NegatveTest()
        {
            /// Arrange 
            Expression expression = new MillionExpression();
            Context context = new Context(1000000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("VVVVV", context.Output);
        }
    }
}
