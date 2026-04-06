/*
 * Filename: MeshPresenterSaveMeshToLocalPlayer.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Saves a mesh from a Mesh Presenter to the local player’s save data. You can use the same Player Save Data name to load the mesh in another room. 
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

[Node("29db83c8-02f2-46a0-a935-8405718b9ef3")]
public class MeshPresenterSaveMeshToLocalPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Mesh Presenter Save Mesh To Local Player";
    public string GetVariableQualifiedName() => "meshPresenterSaveMeshToLocalPlayer";
}