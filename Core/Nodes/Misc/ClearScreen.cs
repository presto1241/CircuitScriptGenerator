/*
 * Filename: ClearScreen.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the target Text Screen
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text Screen)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("142438cd-1bd2-4df2-b2fa-c93aaf99f771")]
public class ClearScreen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Clear Screen";
    public string GetVariableQualifiedName() => "clearScreen";
}