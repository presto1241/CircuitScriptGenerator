/*
 * Filename: WelcomeMatGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return whether target welcome mat is enabled (true) or disabled (false)
 * Types: 
 * 
 * INPUTS: 
 * Target (Welcome Mat)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d26c3f7a-7204-471b-a0bb-5e52960983f8")]
public class WelcomeMatGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Welcome Mat Get Enabled";
    public string GetVariableQualifiedName() => "welcomeMatGetEnabled";
}