using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn : MonoBehaviour
{
    private float count = 6f;
    //public int roundCount;
    public Text startText;
    public Text gameText;
    public Text roundText;
    public Text scoreText;
    public Transform spawnPos;
    public GameObject shape;
    private Color[] colorArray = { Color.red, Color.blue, Color.green, Color.yellow };
    public Sprite[] spriteArray = new Sprite[3];
    public SpriteRenderer sRender;
    private bool gameStart = false;
   


    // Start is called before the first frame update
    void Start()
    {

        roundText.text = "Rounds Left : " + Utilities.roundCount;
        scoreText.text = "Current Score : " + Utilities.scoreCount;
    }


    void initializeBoard()
    {
        sRender = shape.GetComponent<SpriteRenderer>();
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {

                sRender = shape.GetComponent<SpriteRenderer>();
                sRender.color = colorArray[Random.Range(0, 4)];
                sRender.sprite = spriteArray[Random.Range(0, 3)];
                Instantiate(shape, new Vector3(spawnPos.position.x + x, spawnPos.position.y + y, 0), spawnPos.rotation);

            }
        }
        sRender.color = Color.white;
    }

    void setWinConditions()
    {
        sRender = Utilities.winColor.GetComponent<SpriteRenderer>();
        sRender.color = colorArray[Random.Range(0, 4)];
        sRender = Utilities.winShape.GetComponent<SpriteRenderer>();
        sRender.sprite = spriteArray[Random.Range(0, 3)];
    }
    void DestroyBoard(string name)
    {
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("remove"))
            if(g.name == name)
                Destroy(g);
    }

    // Update is called once per frame
    void Update()
    {
        if (Utilities.roundCount > 0)
        {


            count -= Time.deltaTime;
            if (!gameStart)
            {
                if (count <= 0)
                {
                    startText.text = "BEGIN!";
                    gameStart = true;
                    count = 11f;
                    setWinConditions();
                    initializeBoard();
                }
                else
                {
                    startText.text = "Game will begin in : " + (int)count + " seconds";
                }
            }
            else
            {
                if (count <= 0)
                {
                    gameStart = false;
                    count = 6f;
                    DestroyBoard("shape(Clone)");
                    Utilities.roundCount--;
                    roundText.text = "Rounds Left: " + Utilities.roundCount;
                    //find new win condition
                    gameText.text = " ";
                }
                else
                {
                    gameText.text = "Time left : " + (int)count + " seconds";
                }
            }
        }

        scoreText.text = "Current Score: " + Utilities.scoreCount;
    }
}
