using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    private GameObject defence;

    private bool isFull;

    private SpriteRenderer tileSpriteRenderer;
    private Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        tileSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        collider = gameObject.GetComponent<Collider2D>();
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
        defence = TileManager.tileManagerInstance.GetSelectedDefence();

        Instantiate(defence, transform.position, transform.rotation);
        isFull = true;
        tileSpriteRenderer.enabled = false;
    }
}
