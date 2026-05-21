using GLTFast.Schema;
using UnityEditor;
using UnityEngine;

public class CubeGridGenerator : EditorWindow
{
    [MenuItem("Tools/Generate Cube Grid")]
    static void Generate()
    {
        UnityEngine.Material mat = AssetDatabase.LoadAssetAtPath<UnityEngine.Material>("Assets/Level One Assets/BasementColour.mat");
        Debug.Log("Material: " + mat);

        GameObject parent = new GameObject("CubeGrid");

        for (int x = 0; x < 20; x++)
            for (int y = 0; y < 4; y++)
                for (int z = 0; z < 20; z++)
                {
                    
                    if (x < 2 || x > 5 || z < 2 || z > 5 || y < 2)
                    {
                        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube.transform.position = new Vector3(x, y, z);
                        cube.transform.parent = parent.transform;
                        cube.GetComponent<Renderer>().material = mat;
                        BoxCollider collide = cube.AddComponent<BoxCollider>();
                        if (x != 0 && y != 0 && z != 0)
                            cube.AddComponent<cube>();
                    }                   
                }
    }
}