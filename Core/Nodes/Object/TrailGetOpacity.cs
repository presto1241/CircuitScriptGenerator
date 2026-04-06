/*
 * Filename: TrailGetOpacity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max opacity of the target Motion Trail object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Motion Trail)
 *
 * OUTPUTS: 
 * Max Opacity (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6dcc7a44-0163-4058-97a9-1ef7f482a3d5")]
public class TrailGetOpacity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Get Opacity";
    public string GetVariableQualifiedName() => "trailGetOpacity";
}