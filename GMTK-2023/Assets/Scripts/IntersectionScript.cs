using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class IntersectionScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _highlight;

    [SerializeField]
    private GameObject[] _parts;

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
            _parts[0].SetActive(false);
            _parts[1].SetActive(false);
            _parts[2].SetActive(false);
            _parts[3].SetActive(false);
        }
        else
        {
            _collider.isTrigger = false;
            _parts[0].SetActive(true);
            _parts[1].SetActive(true);
            _parts[2].SetActive(true);
            _parts[3].SetActive(true);
        }
        var graphToScan = AstarPath.active.data.gridGraph;
        AstarPath.active.Scan(graphToScan);
    }
}
