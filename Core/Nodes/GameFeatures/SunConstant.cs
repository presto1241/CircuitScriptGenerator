/*
 * Filename: SunConstant.cs
 * Category: Game Features
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Defines values for the room's sun.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Sun)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Game Features;

[Node("26062297-4aab-4fd4-bfb8-95fbf64f6bb7")]
public class SunConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Sun Constant";
    public string GetVariableQualifiedName() => "sunConstant";
}