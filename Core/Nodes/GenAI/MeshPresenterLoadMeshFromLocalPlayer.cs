/*
 * Filename: MeshPresenterLoadMeshFromLocalPlayer.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a mesh from the local player’s save data and loads it into a Mesh Presenter. You can use this to load meshes across rooms.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Mesh Presenter)
 * Player Save Data Name (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("aaf7ec8c-35d7-4ee9-87d1-cc0c78745150")]
public class MeshPresenterLoadMeshFromLocalPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Mesh Presenter Load Mesh From Local Player";
    public string GetVariableQualifiedName() => "meshPresenterLoadMeshFromLocalPlayer";
}