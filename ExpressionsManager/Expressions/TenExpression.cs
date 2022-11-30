using Cyient.Facade;

namespace Cyient.Expressions
{

    /// <summary>
    /// Class to handle the values less the 100
    /// </summary>
    public class TenExpression : TerminalExpression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }
}
