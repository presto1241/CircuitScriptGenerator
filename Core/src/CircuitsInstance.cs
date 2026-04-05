/*
 * Filename: CircuitsInstance.cs
 * Created Date: Tuesday, March 31st 2026, 11:35:50 pm
 * Author: Preston
 * 
 * Description: This is the main class for the CircuitScriptGenerator library.
 * This class contains all the data needed to view and export circuit graphs.
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core;


public class CircuitsInstance
{
    #region Static
    /// <summary>
    /// Load a new CircuitsInstance from file
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static bool Load(string filePath, out CircuitsInstance? instance)
    {
        instance = null;
        if (!File.Exists(filePath)) return false;

        // @todo: Verify you can load the file

        return true;
    }


    /// <summary>
    /// Load a new CircuitsInstance asyncronously from file
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="progress"></param>
    /// <returns></returns>
    public async static Task<CircuitsInstance?> LoadAsync(
        string filePath, 
        IProgress<float>? progress = null
        )
    {
        CircuitsInstance? instance = null;
        if (!File.Exists(filePath)) return null;

        // @todo: Verify you can load the file

        return instance;
    }
    #endregion

    #region Instance
    public string Name { get; private set; }

    public IReadOnlyList<Graph> Graphs => _graphs;
    private List<Graph> _graphs = new();


    /// <summary>
    /// Construct a new CircuitsInstance with the rooms/inventions byte[] data.
    /// </summary>
    /// <param name="data">The room data</param>
    public CircuitsInstance(byte[] data)
    {
        // Lazy loading nodes here :)
        if (!NodeStorage.GetNodesLoaded()) NodeStorage.LoadNodes();
        
        // @todo: Work on parsing data to usable data.
    }

    /// <summary>
    /// Get an array of all the entry node names of each graph.
    /// </summary>
    /// <returns></returns>
    public string[] GetAllGraphNames()
    {
        string[] names = new string[_graphs.Count];

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = _graphs[i].GetEntryName();
        }

        return names;
    }

    /// <summary>
    /// Set the name of the current instance
    /// May not be necessary to set through method in the future.
    /// </summary>
    /// <param name="name"></param>
    public void SetName(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Export all graphs to a specfic directory.
    /// </summary>
    /// <param name="directory"></param>
    public void Export(string directory)
    {}
    
    /// <summary>
    /// Export specific set of graphs to directory.
    /// </summary>
    /// <param name="directory">The directory to export</param>
    /// <param name="graphs">An index array of graphs</param>
    public void Export(string directory, int[] graphs)
    {}
    #endregion
}
