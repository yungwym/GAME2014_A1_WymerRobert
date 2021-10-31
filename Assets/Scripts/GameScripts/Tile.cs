using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private GameObject defence;
    public bool isFull;
    public SpriteRenderer tileSpriteRenderer;
    private Collider2D collider;
    private TileManager tileManager;

    // Start is called before the first frame update
    void Start()
    {
        tileManager = TileManager.tileManagerInstance;

        tileSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        collider = gameObject.GetComponent<Collider2D>();
        tileSpriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 pos = new Vector2(touchPosition.x, touchPosition.y);

            if (collider.bounds.Contains(pos) && isFull == false)
            {
                PlaceDefence();
            }
        }
    }

    void PlaceDefence()
    {
        if (tileManager.tileHasBeenSelected == true)
        {
            tileManager.PlaceDefence(transform, transform.rotation);
            isFull = true;
            tileSpriteRenderer.enabled = false;
            tileManager.HideActiveTiles();
            tileManager.SetSelectedDefenceToNull();
        }
    }
}
