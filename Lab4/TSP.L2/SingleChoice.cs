using System;

namespace SOLID.OCP
{
    abstract public class BankTerminal
    {
    }

    public class BrpTerminal : BankTerminal
    {
    }

    public class DcpTerminal : BankTerminal
    {
    }

    abstract public class BankTerminalFactory
    {
        public abstract BankTerminal CreateBankTerminal();
    }

    public class Brp : BankTerminalFactory
    {
        public override BankTerminal CreateBankTerminal()
        {
            return new BrpTerminal();
        }
    }

    public class Dcp : BankTerminalFactory
    {
        public override BankTerminal CreateBankTerminal()
        {
            return new DcpTerminal();
        }
    }
}