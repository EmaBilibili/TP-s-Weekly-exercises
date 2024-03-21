using UnityEngine;

public class RecursiveCube : MonoBehaviour
{
    public GameObject cubePrefab;
    public int pyramidHeight = 5;

    void Start()
    {
        CreatePyramid(transform.position, pyramidHeight);
    }

    void CreatePyramid(Vector3 position, int height)
    {
        if (height == 0)
            return;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Vector3 cubePosition = position + new Vector3(-i / 2.0f + j, -height + 1, i);
                GameObject cube = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
                cube.transform.SetParent(transform);
            }
        }

        Vector3 nextPyramidPosition = position + new Vector3(0, 1, 0); 
        CreatePyramid(nextPyramidPosition, height - 1); 
    }
}