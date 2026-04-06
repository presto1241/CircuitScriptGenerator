/*
 * Filename: TextureVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stores a variable of type Texture, which can reference either a Render Texture or a Texture2D.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Texture)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Texture)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("ff5477ca-e877-416e-bdef-406ac361baa9")]
public class TextureVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Texture Variable";
    public string GetVariableQualifiedName() => "textureVariable";
}