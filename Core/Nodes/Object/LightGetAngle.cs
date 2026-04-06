/*
 * Filename: LightGetAngle.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the angle in degrees of the target Dome Light or Spotlight.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Angle (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8a6c0623-7585-402c-8734-7fa7248b15a0")]
public class LightGetAngle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Angle";
    public string GetVariableQualifiedName() => "lightGetAngle";
}