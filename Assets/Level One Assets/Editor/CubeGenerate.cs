using UnityEngine;
using UnityEditor;

public class CubeGridGenerator : EditorWindow
{
    [MenuItem("Tools/Generate Cube Grid")]
    static void Generate()
    {
        Material mat = AssetDatabase.LoadAssetAtPath<Material>("Assets/Level One Assets/BasementColour.mat");
        Debug.Log("Material: " + mat);

        GameObject parent = new GameObject("CubeGrid");

        for (int x = 0; x < 20; x++)
            for (int y = 0; y < 4; y++)
                for (int z = 0; z < 20; z++)
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(x, y, z);
                    cube.transform.parent = parent.transform;
                    cube.GetComponent<Renderer>().material = mat;
                }
    }
}