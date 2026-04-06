/*
 * Filename: ScriptGenerator.cs
 * Created Date: Sunday, April 5th 2026, 1:34:08 pm
 * Author: Preston
 * 
 * Description: This is a script that runs through a given graph and generates code for it.
 */

namespace CircuitScriptGenerator.Core.Api.Generation;

public class ScriptGenerator
{
    #region Static
    /* I plan to move this whole system over to a json file in the future */
    public const string PathToTemplates = "Templates";
    public static string GetTemplatePath(GenerationTemplate template)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), PathToTemplates);

        if (!Directory.Exists(path))
        {
            Console.WriteLine($"[Error] [ScriptGenerator] Could not find templates file! Are you running the exe in the right directory?");
            throw new DirectoryNotFoundException();
        }

        switch (template)
        {
            case GenerationTemplate.Standalone:
            path += "/Standalone";
            break;

            case GenerationTemplate.Unity:
            path += "/Unity";
            break;

            case GenerationTemplate.VRChat:
            path += "/VRChat";
            break;
        }

        return path;
    }
    #endregion

    #region Instance
    
    #endregion
}