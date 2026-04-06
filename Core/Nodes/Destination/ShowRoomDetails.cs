/*
 * Filename: ShowRoomDetails.cs
 * Category: Destination
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Destination Room (Destination Room)
 * Player (Player)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Destination;

[Node("848ceade-1a44-4609-9f06-e85ee55fa9bc")]
public class ShowRoomDetails : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Room Details";
    public string GetVariableQualifiedName() => "showRoomDetails";
}