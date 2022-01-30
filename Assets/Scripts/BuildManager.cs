using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class BuildManager : MonoBehaviour
{
    public Tilemap tilemap;     // renders tiles
    public Tile[] tiles;        // list of tiles we can draw
    public List<GameObject> UITiles;    // the tiles we create dynamically though the tiles list

    public int selectedTile = 0;    // current tile we have access to

    public Transform tileGridUI;    // tiles we add from UITiles

    private void Start()
    {
        int i = 0;

        //creates our UI
        foreach (Tile tile in tiles)
        {
            GameObject UITile = new GameObject("UI Tile");
            UITile.transform.parent = tileGridUI;
            UITile.transform.localScale = new Vector3(1f, 1f, 1f);
            
            Image UIImage = UITile.AddComponent<Image>();
            UIImage.sprite = tile.sprite;

            Color tileColor = UIImage.color;
            tileColor.a = 0.5f;

            if (i == selectedTile)
            {
                tileColor.a = 1f;
            }

            UIImage.color = tileColor;
            
            UITiles.Add(UITile);

            i++;
        }
    }
}
