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
    public class HundredExpression_UnitTest
    {
        [TestMethod]
        public void HundredExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new OneExpression();
            Context context = new Context(100);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("IXIXIXIXIXIXIXIXIXIXIXI", context.Output);
        }

        [TestMethod]
        public void HundredExpression_NegatveTest()
        {
            /// Arrange 
            Expression expression = new OneExpression();
            Context context = new Context(100);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("VVVVV", context.Output);
        }
    }
}
