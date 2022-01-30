using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;    // Write code relating to UI element

public class BuildManager : MonoBehaviour
{
    public Tilemap tilemap;     // renders tiles
    public Tile[] tiles;        // list of tiles we can draw
    public List<GameObject> UITiles;    // the tiles we create dynamically though the tiles list

    public int selectedTile = 0;    // current tile we have access to

    public Transform tileGridUI;    // tiles we add from UITiles

    //  for creating a new plant object on click
    private Vector3 mousePos;
    private Vector3 objectPos;
    private Camera cam;
    public GameObject plantPrefab;  // Plant prefab

    public TextMeshProUGUI dayCountText;
    public int day;
    public int dayUpdate;

    private void Start()
    {
        cam = Camera.main;

        // displays day
        day = 0;
        dayUpdate = 5;
        setDayText();

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedTile = 0;
            RenderUITiles();
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedTile = 1;
            RenderUITiles();
        }

        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 2.0f;
            objectPos = cam.ScreenToWorldPoint(mousePos);
            Debug.Log("Mouse spawn coords: " + objectPos);
            GameObject plantObject = Instantiate(plantPrefab, objectPos, Quaternion.identity);
            /*
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tilemap.SetTile(tilemap.WorldToCell(position), tiles[selectedTile]);
            */
        }

        Debug.Log(Time.realtimeSinceStartup);
        if (Time.realtimeSinceStartup > dayUpdate)
        {
            dayUpdate += 5;
            setDayText();   // increases day every 10 seconds
        }
    }

    void RenderUITiles()
    {
        int i = 0;

        foreach (GameObject tile in UITiles)
        {
            Image UIImage = tile.GetComponent<Image>();
            Color tileColor = UIImage.color;
            tileColor.a = 0.5f;

            if (i == selectedTile)
            {
                tileColor.a = 1f;
            }

            UIImage.color = tileColor;

            i++;
        }
    }

    void setDayText()
    {
        day += 1;
        dayCountText.text = "Day " + day;
    }
}
