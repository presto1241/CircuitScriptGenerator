/*
 * Filename: SpawnerInternalStartSpawning.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Spawner (Rec Room Object)
 * Amount of objects to spawn (int)
 * Time between spawns (float)
 * Spawn Position (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fb6a63b1-3f55-4dcf-9bf0-6ef82e3296d5")]
public class SpawnerInternalStartSpawning : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Spawner Internal Start Spawning";
    public string GetVariableQualifiedName() => "spawnerInternalStartSpawning";
}