using Cyient.Facade;

namespace Cyient.Expressions
{
    /// <summary>
    /// Class to handle the values in hundreds
    /// </summary>
    public class HundredExpression : TerminalExpression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }
}
