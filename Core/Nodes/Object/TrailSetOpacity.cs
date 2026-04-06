/*
 * Filename: TrailSetOpacity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the max opacity of the target Motion Trail object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Motion Trail)
 * Max Opacity (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bb79cf12-6d38-4691-a004-c2b3ad963374")]
public class TrailSetOpacity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Set Opacity";
    public string GetVariableQualifiedName() => "trailSetOpacity";
}