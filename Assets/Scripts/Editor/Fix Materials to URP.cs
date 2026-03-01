using UnityEngine;
using UnityEditor;

public class FixMaterials : MonoBehaviour
{
    [MenuItem("Tools/Fix Materials to URP")]
    static void FixAllMaterials()
    {
        string[] guids = AssetDatabase.FindAssets("t:Material", new[] {"Assets/Sci Fi Modular Pack/Materials"});
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Material mat = AssetDatabase.LoadAssetAtPath<Material>(path);
            mat.shader = Shader.Find("Universal Render Pipeline/Lit");
            EditorUtility.SetDirty(mat);
        }
        AssetDatabase.SaveAssets();
        Debug.Log("Materiais convertidos!");
    }
}