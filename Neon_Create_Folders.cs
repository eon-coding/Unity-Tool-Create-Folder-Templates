
using UnityEditor;
using UnityEngine;

public class Neon_Create_Folders : EditorWindow
{
    [MenuItem("My Tools/ Create Folders Window")]
    public static void ShowWindow()
    {

        Neon_Create_Folders window = (Neon_Create_Folders)EditorWindow.GetWindow(typeof(Neon_Create_Folders));
        window.Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Create Folders"))
        {
            Debug.Log("Folders Created");

            AssetDatabase.CreateFolder("Assets", "My Folder");
            AssetDatabase.CreateFolder("Assets", "FX");
            AssetDatabase.CreateFolder("Assets", "Level Assets");
            AssetDatabase.CreateFolder("Assets", "Post Processing");
            AssetDatabase.CreateFolder("Assets", "Props");
            AssetDatabase.CreateFolder("Assets", "Scripts");
            AssetDatabase.CreateFolder("Assets", "Sound");
            AssetDatabase.CreateFolder("Assets", "Standard Assets");
            AssetDatabase.CreateFolder("Assets", "Animations");
            
        }
    }
}
