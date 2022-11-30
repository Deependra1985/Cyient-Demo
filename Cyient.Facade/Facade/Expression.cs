using Cyient.Common.Models;

namespace Cyient.Facade
{
    public abstract class Expression
    {
        public abstract void Interpret(Context value);
    }
}
