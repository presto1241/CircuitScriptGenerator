/*
 * Filename: GoToRoom.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Execution sends the specified player to a preconfigured destination. Use a destination constant or variable to specify the destination of this chip. Follow settings are a property of the destination.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Destination (Destination Room)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("bad6a57b-2af8-4526-8caa-e07476da4a5b")]
public class GoToRoom : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Go To Room";
    public string GetVariableQualifiedName() => "goToRoom";
}