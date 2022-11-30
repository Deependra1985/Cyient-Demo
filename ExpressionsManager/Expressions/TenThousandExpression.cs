using Cyient.Facade;

namespace Cyient.Expressions
{
    public class TenThousandExpression : TerminalExpression
    {
        public override string One() { return "x"; }
        public override string Four() { return "xl"; }
        public override string Five() { return "l"; }
        public override string Nine() { return "xc"; }
        public override int Multiplier() { return 10000; }
    }
}
