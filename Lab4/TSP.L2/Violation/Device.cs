using System;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    abstract public class Device
    {
        protected SerialPort port = new SerialPort();

        abstract public string FindDevice();

        protected string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }

    public class BillAccepterCashCode : Device
    {
        public override string FindDevice()
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return Find(port);
        }
    }

    public class BillDispenserEcdm : Device
    {
        public override string FindDevice()
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return Find(port);
        }
    }

    public class CoinAccepterNri : Device
    {
        public override string FindDevice()
        {
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return Find(port);
        }
    }

    public class CoinDispenserCube4 : Device
    {
        public override string FindDevice()
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return Find(port);
        }
    }

    public class CoinDispsenerSch2 : Device
    {
        public override string FindDevice()
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return Find(port);
        }
    }
}