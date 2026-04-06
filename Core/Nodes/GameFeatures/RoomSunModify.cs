/*
 * Filename: RoomSunModify.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Modify (exec)
 * Sun Constant (Sun)
 * Sun Direction (Sun Direction)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Blend Finished (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("884408a8-5884-41e4-9399-1b0ef5d353e0")]
public class RoomSunModify : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Sun Modify";
    public string GetVariableQualifiedName() => "roomSunModify";
}