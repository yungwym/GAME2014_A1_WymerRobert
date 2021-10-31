using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager tileManagerInstance;

    [SerializeField] private GameObject selectedDefence;

    private Tile[] tiles;

    // Start is called before the first frame update
    void Awake()
    {
        if (tileManagerInstance != null)
        {
            return;
        }
        tileManagerInstance = this;
    }

    private void Start()
    {
        tiles = FindObjectsOfType<Tile>();
    }

    public GameObject GetSelectedDefence()
    {
        return selectedDefence;
    }

    public void SetSelectedDefence(GameObject selectedDef)
    {
        selectedDefence = selectedDef;
    }


    public void ShowActiveTiles()
    {
        foreach (var tile in tiles)
        {
            if (tile.isFull == false)
            {
                tile.tileSpriteRenderer.enabled = true;
            }
        }
    }

    public void HideActiveTiles()
    {
        foreach (var tile in tiles)
        {
            tile.tileSpriteRenderer.enabled = false;
        }
    }
}
