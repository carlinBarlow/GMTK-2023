using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class IntersectionScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _highlight;

    [SerializeField]
    private GameObject _blockade;

    private BoxCollider2D _collider;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<BoxCollider2D>();

        _collider.isTrigger = true;
    }

    // Update is called once per frame
    void Update() { }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    void OnMouseDown()
    {
        if (_collider.isTrigger == false)
        {
            _collider.isTrigger = true;
        }
        else
        {
            _collider.isTrigger = false;
        }
        var graphToScan = AstarPath.active.data.gridGraph;
        AstarPath.active.Scan(graphToScan);
    }
}
