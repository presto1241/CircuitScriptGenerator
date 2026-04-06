/*
 * Filename: GetAllLocalPlayerMeshes.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets all of the meshes saved to the local player's save data.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Player Save Data Names (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("7272fef4-023a-4674-aefc-2c7603e90127")]
public class GetAllLocalPlayerMeshes : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Local Player Meshes";
    public string GetVariableQualifiedName() => "getAllLocalPlayerMeshes";
}