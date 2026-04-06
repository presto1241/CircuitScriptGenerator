/*
 * Filename: WelcomeMatSetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set target welcome mat to be enabled (true) or disabled (false)
 * Types: 
 * 
 * INPUTS: 
 * SetEnabled (exec)
 * Target (Welcome Mat)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * SetEnabled (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d503f1b3-7c5e-4eba-85ac-b89be2d2360f")]
public class WelcomeMatSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Welcome Mat Set Enabled";
    public string GetVariableQualifiedName() => "welcomeMatSetEnabled";
}