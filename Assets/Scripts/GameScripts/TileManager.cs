using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager tileManagerInstance;

    [SerializeField] private GameObject selectedDefence;

    // Start is called before the first frame update
    void Awake()
    {
        if (tileManagerInstance != null)
        {
            return;
        }
        tileManagerInstance = this;
    }

    public GameObject GetSelectedDefence()
    {
        return selectedDefence;
    }
}
