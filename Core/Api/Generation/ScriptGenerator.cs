/*
 * Filename: ScriptGenerator.cs
 * Created Date: Sunday, April 5th 2026, 1:34:08 pm
 * Author: Preston
 * 
 * Description: This is a script that runs through a given graph and generates code for it.
 */

using System.Reflection;

namespace CircuitScriptGenerator.Core.Api.Generation;

public class ScriptGenerator
{
    #region Static
    /* I plan to move this whole system over to a json file in the future */
    public const string PathToTemplates = "Templates";
    public static string GetTemplate(GenerationTemplate template, FileTemplate fileTemplate = FileTemplate.Class)
    {
        string path = ".Templates.";

        switch (template)
        {
            case GenerationTemplate.Standalone:
            path += "Standalone.";
            break;

            case GenerationTemplate.Unity:
            path += "Unity.";
            break;

            case GenerationTemplate.VRChat:
            path += "VRChat.";
            break;
        }

        switch (fileTemplate)
        {
            case FileTemplate.Class:
            path += "Class.scriban";
            break;
            
            case FileTemplate.Events:
            path += "Events.scriban";
            break;
        }

        var assembly = Assembly.GetExecutingAssembly();
        Stream? stream = assembly.GetManifestResourceStream(assembly.GetName().Name + path);

        if (stream == null)
        {
            throw new FileNotFoundException("Could not find generation template in assembly.");
        }

        StreamReader reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
    #endregion

    #region Instance
    
    #endregion
}