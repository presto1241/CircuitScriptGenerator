/*
 * Filename: CommunityEventConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A constant chip that can be configured to point at a Community Event that's happening in the future, and pipe that data into circuits
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Community Event)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("ab9cf11c-a9fa-41e0-91ac-c241e152e986")]
public class CommunityEventConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Community Event Constant";
    public string GetVariableQualifiedName() => "communityEventConstant";
}