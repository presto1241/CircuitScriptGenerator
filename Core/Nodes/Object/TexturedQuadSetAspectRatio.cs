/*
 * Filename: TexturedQuadSetAspectRatio.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the aspect ratio of a textured quad.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Textured Quad)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4c64aa6a-eb11-4dcb-be6d-cdd06364e386")]
public class TexturedQuadSetAspectRatio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Textured Quad Set Aspect Ratio";
    public string GetVariableQualifiedName() => "texturedQuadSetAspectRatio";
}