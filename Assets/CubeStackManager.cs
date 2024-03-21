using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackManager : MonoBehaviour
{
    private Stack<GameObject> cubeStack = new Stack<GameObject>();
    // Prefab del cubo que será generado
    public GameObject cubePrefab;
    // Posición específica donde se instanciarán los cubos
    public Vector3 spawnPosition;
    void Update()
    {
        // Generar un cubo al presionar el clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            GenerateCube();
        }
        // Eliminar un cubo al presionar el clic derecho
        else if (Input.GetMouseButtonDown(1))
        {
            RemoveCube();
        }
    }
    // Método para generar un cubo y apilarlo
    void GenerateCube()
    {
        GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        cubeStack.Push(newCube);
    }
    // Método para eliminar el último cubo generado (desapilar)
    void RemoveCube()
    {
        if (cubeStack.Count > 0)
        {
            GameObject cubeToRemove = cubeStack.Pop();
            Destroy(cubeToRemove);
        }
        else
        {
            Debug.Log("No hay cubos para eliminar en la pila.");
        }
    }
}