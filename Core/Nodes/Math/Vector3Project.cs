/*
 * Filename: Vector3Project.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Projects a vector onto a normal
 * Types: 
 * 
 * INPUTS: 
 * Vector (Vector3)
 * On Normal (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("11dcd185-ffb5-476e-a469-d0588f36a2f8")]
public class Vector3Project : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Project";
    public string GetVariableQualifiedName() => "vector3Project";
}