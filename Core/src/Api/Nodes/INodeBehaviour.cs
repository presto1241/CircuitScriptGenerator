/*
 * Filename: INodeBehaviour.cs
 * Created Date: Sunday, April 5th 2026, 1:22:47 am
 * Author: Preston
 * 
 * Description: An interface that lets nodes easily be called from other scripts.
 */
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Api.Nodes;

public interface INodeBehaviour
{
    /// <summary>
    /// Get the human readable name of the chip
    /// </summary>
    /// <returns></returns>
    public string GetName();

    /// <summary>
    /// Get the variable qualified name of the chip.
    /// The name is in camelCase.
    /// </summary>
    /// <returns></returns>
    public string GetVariableQualifiedName();

    /// <summary>
    /// Generate code for this chip
    /// </summary>
    /// <param name="inputPorts">The input ports of the chip</param>
    /// <param name="outputPorts">The output ports of the chip</param>
    public void Generate(
        List<Port> inputPorts, 
        List<Port> outputPorts
        );
}