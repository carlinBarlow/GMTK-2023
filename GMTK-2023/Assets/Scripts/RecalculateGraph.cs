using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RecalculateGraph : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("CheckPath", 0f, 3f);
    }

    // Update is called once per frame
    void FixedUpdate() { }

    void CheckPath()
    {
        var graphToScan = AstarPath.active.data.gridGraph;
        AstarPath.active.Scan(graphToScan);
    }
}
