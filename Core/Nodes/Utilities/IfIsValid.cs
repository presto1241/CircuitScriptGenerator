/*
 * Filename: IfIsValid.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A combination of an If chip and the Is Valid chip. Returns True if the input value is valid - meaning that it can be used by other chips.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Value (T) - The value to check for validity
 *
 * OUTPUTS: 
 * Is Valid (exec) - Exec port that is fired if Value is valid.
 * Is Not Valid (exec) - Exec port that is fired if Value is not valid.
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("ff6fe183-040d-4203-808e-5c23b39f304b")]
public class IfIsValid : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Is Valid";
    public string GetVariableQualifiedName() => "ifIsValid";
}