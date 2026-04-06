/*
 * Filename: AISetPathingSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Speed (m/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cd85a0c7-789b-41a2-aeda-40925b73738c")]
public class AISetPathingSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Set Pathing Speed";
    public string GetVariableQualifiedName() => "aISetPathingSpeed";
}