/*
 * Filename: AddAnalyticsEventProperty.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: (bool | float | int | string)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Payload (Analytics Payload)
 * Property Name (string)
 * Value (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("c6cd5f1c-bc01-4af9-9bee-b1476cd2cab7")]
public class AddAnalyticsEventProperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Add Analytics Event Property";
    public string GetVariableQualifiedName() => "addAnalyticsEventProperty";
}