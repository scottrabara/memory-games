using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject shape;
    private Color[] colorArray = { Color.red, Color.blue, Color.green, Color.yellow };
    public Sprite[] spriteArray = new Sprite[3];
    public SpriteRenderer sRender;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int x = 0; x<5; x++)
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
