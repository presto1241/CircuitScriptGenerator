/*
 * Filename: RoomieAIRequestResponse.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Send the specified prompt to the local player's Roomie AI Companion, if they have one. 
If the Roomie AI can not get to this request before the timeout, it will expire.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt (string)
 * TimeoutSeconds (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("07ab23d6-252b-43d4-b104-d399b3889162")]
public class RoomieAIRequestResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Roomie AI Request Response";
    public string GetVariableQualifiedName() => "roomieAIRequestResponse";
}