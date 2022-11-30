using Cyient.Facade;

namespace Cyient.Expressions
{
    public class MillionExpression : TerminalExpression
    {
        public override string One() { return "m"; }
        public override string Four() { return ""; }
        public override string Five() { return ""; }
        public override string Nine() { return ""; }
        public override int Multiplier() { return 1000000; }
    }
}
