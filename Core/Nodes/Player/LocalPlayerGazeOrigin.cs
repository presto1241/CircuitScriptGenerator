/*
 * Filename: LocalPlayerGazeOrigin.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the origin of Local Player Gaze.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Vector (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("44d9ad9e-8f31-4588-903d-1bbe8d3c3b70")]
public class LocalPlayerGazeOrigin : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Gaze Origin";
    public string GetVariableQualifiedName() => "localPlayerGazeOrigin";
}