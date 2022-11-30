using Cyient.Facade;

namespace Cyient.Expressions
{
    public class ThousandExpression : TerminalExpression
    {
        public override string One() { return "M"; }
        public override string Four() { return "Mv"; }
        public override string Five() { return "v"; }
        public override string Nine() { return "Mx"; }
        public override int Multiplier() { return 1000; }
    }
}
