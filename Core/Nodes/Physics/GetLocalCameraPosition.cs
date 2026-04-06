/*
 * Filename: GetLocalCameraPosition.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the position of your avatar's view, output as a Vector3.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("c19eff8a-980c-444a-983f-bb4c53a94daf")]
public class GetLocalCameraPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Local Camera Position";
    public string GetVariableQualifiedName() => "getLocalCameraPosition";
}