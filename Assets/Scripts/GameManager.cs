using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************
 * GIDS4101 - BATTLE QUEST
 * GameManager: This script can manage properties of Game Scene
 * Authors: @Francisco Alvarez & @Daniela Cruz
 ******************************************************************/

public class GameManager : MonoBehaviour
{
    public float vel = 1;

    public Renderer background;
    public GameObject colGrass;
    public List<GameObject> cols;
    // Start is called before the first frame update
    void Start()
    {
        // Create Grass Map
        for (int i = 0; i < 21; i++)
        {
           cols.Add(Instantiate(colGrass, new Vector2(-10 + i, -3), Quaternion.identity));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move background
        background.material.mainTextureOffset = background.material.mainTextureOffset + new Vector2(0.02f, 0) * Time.deltaTime;

        // Move Grass Map
        for (int i = 0; i < cols.Count; i++)
        {
            if (cols[i].transform.position.x <= -10)
            {
                cols[i].transform.position = new Vector3(10, -3, 0);
            }
            cols[i].transform.position = cols[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * vel;
        }
    }
}
