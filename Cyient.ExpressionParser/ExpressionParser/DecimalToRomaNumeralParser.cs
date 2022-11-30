using Cyient.Facade;
using Cyient.Common.Models;
using Cyient.Expressions;

namespace Cyient.ExpressionParser
{
    public class DecimalToRomaNumeralParser : IParser
    {
        private List<Expression> expressionTree = new List<Expression>()
                                                      {
                                                          new MillionExpression(),
                                                          new HundredThousandExpression(),
                                                          new TenThousandExpression(),
                                                          new ThousandExpression(),
                                                          new HundredExpression(),
                                                          new TenExpression(),
                                                          new OneExpression()
                                                      };

        public void Parse(Context value)
        {
            foreach (Expression exp in expressionTree)
            {
                exp.Interpret(value);
            }
        }
    }
}
