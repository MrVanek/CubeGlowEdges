using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineScript : MonoBehaviour
{
    Mesh myMesh;
    LineRenderer lr;
    

    void Start()
    {
        myMesh = GetComponent<MeshFilter>().mesh;
        lr = GetComponent<LineRenderer>();
        Vector3[] meshList = myMesh.vertices;
        lr.positionCount = myMesh.vertexCount;

        UpdateLine(meshList);
    }

    private void UpdateLine(Vector3[] meshList)
    {
        for (int i = 0; i < myMesh.vertexCount; i++)
        {
                lr.SetPosition(i, meshList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
