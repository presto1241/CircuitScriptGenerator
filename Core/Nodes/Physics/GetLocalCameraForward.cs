/*
 * Filename: GetLocalCameraForward.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the direction your avatar is looking, output as a Vector3.
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

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("70c830bb-223a-4a7c-b0ae-df240c6f1f33")]
public class GetLocalCameraForward : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Local Camera Forward";
    public string GetVariableQualifiedName() => "getLocalCameraForward";
}