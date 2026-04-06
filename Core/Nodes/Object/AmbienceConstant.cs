/*
 * Filename: AmbienceConstant.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Choose from a selection of ambient audio tracks, for use with the Audio Player.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Audio)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1ad615de-65ea-40a3-b500-3a5b56b2a65d")]
public class AmbienceConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ambience Constant";
    public string GetVariableQualifiedName() => "ambienceConstant";
}