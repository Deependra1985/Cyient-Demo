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
    public class HundredThousandExpression_UnitTest
    {
        [TestMethod]
        public void HundredThousandExpression_PossitiveTest()
        {
            /// Arrange 
            Expression expression = new HundredThousandExpression();
            Context context = new Context(100000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreEqual("c", context.Output);
        }

        [TestMethod]
        public void HundredExpression_NegatveTest()
        {
            /// Arrange 
            Expression expression = new HundredThousandExpression();
            Context context = new Context(100000);
            /// Act 
            expression.Interpret(context);
            /// Assert
            Assert.AreNotEqual("VVVVV", context.Output);
        }
    }
}
