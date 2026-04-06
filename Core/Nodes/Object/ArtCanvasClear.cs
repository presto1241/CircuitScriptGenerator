/*
 * Filename: ArtCanvasClear.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the current image from the Art Canvas.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Art Canvas)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6e1e628f-ed0d-4c2a-80a4-1d38e9021916")]
public class ArtCanvasClear : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Art Canvas Clear";
    public string GetVariableQualifiedName() => "artCanvasClear";
}