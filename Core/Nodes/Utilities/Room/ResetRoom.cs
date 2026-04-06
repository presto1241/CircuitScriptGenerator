/*
 * Filename: ResetRoom.cs
 * Category: Utilities/Room
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Resets the Room.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities/Room;

[Node("e921b08d-10c2-4be4-86fe-b8c7155cb97b")]
public class ResetRoom : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Reset Room";
    public string GetVariableQualifiedName() => "resetRoom";
}