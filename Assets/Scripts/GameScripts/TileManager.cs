using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager tileManagerInstance;

    private GameObject selectedDefence = null;

    public bool tileHasBeenSelected = false;

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

    public void SetSelectedDefenceToNull()
    {
        selectedDefence = null;
        tileHasBeenSelected = false;
    }

    public void SetSelectedDefence(GameObject selectedDef)
    {
        selectedDefence = selectedDef;
        tileHasBeenSelected = true;
    }


    public void PlaceDefence(Transform defenceTransform, Quaternion defenceQuaternion)
    {
        if (selectedDefence != null)
        {
            Instantiate(selectedDefence, defenceTransform.position, defenceQuaternion);
        }
        else
        {
            Debug.Log("No Selected Defence");
        }
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
