/*
 * Filename: Connection.cs
 * Created Date: Thursday, April 9th 2026, 4:44:30 pm
 * Author: Preston
 * 
 * Description: Handles a connection between an input port and any number of output ports.
 */

namespace CircuitScriptGenerator.Core.Data;

public class Connection
{
    Port StartPort { get; }
    Port[] EndPorts { get; }

    public Connection(Port startPort, Port[] endPorts)
    {
        StartPort = startPort;
        EndPorts = endPorts; 
    }
}