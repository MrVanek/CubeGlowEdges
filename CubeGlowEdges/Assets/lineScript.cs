using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineScript : MonoBehaviour
{
    Mesh myMesh;
    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        myMesh = GetComponent<MeshFilter>().sharedMesh;
        lr = GetComponent<LineRenderer>();
        Vector3[] meshList = myMesh.vertices;
        lr.positionCount = myMesh.vertexCount;
        
        for (int i = 0; i < myMesh.vertexCount; i++)
        {
            //if (i !=0 )
            {
                lr.SetPosition(i, new Vector3 (meshList[i].x, meshList[i].y, meshList[i].z));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
