using NationalInstruments.Visa;
using System;
//using Ivi.Visa;

namespace PhotonicsSuite.Hardware
{
    // ReSharper disable once InconsistentNaming
    public class TSL570
    {
        private MessageBasedSession _io;

        public TSL570(string resourceName = "TCPIP0::172.28.5.15::5000::SOCKET")
        {
            var laserManager = new ResourceManager();
            _io = (MessageBasedSession)laserManager.Open(resourceName);
            _io.TerminationCharacterEnabled = true;
        }
        
        private void Write(string cmd)
        {
            _io.RawIO.Write(cmd.CommandExt());
        }
    }
}

public static class Command
{
    public static string CommandExt(this string command)
    {
        command = string.Concat(command, "\r");
        return command;
    }
}