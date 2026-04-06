/*
 * Filename: Reroute.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used to remove spaghetti from your creations. Consumes additional CPU heat.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (T)
 *
 * OUTPUTS: 
 * (unnamed) (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("f8db4ba2-7380-49a0-a0ba-bcdca11fec96")]
public class Reroute : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Reroute";
    public string GetVariableQualifiedName() => "reroute";
}