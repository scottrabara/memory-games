using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities 

{
    public static int roundCount = 5;
    public static int scoreCount = 0;
    public static GameObject winColor = GameObject.FindGameObjectWithTag("color");
    public static GameObject winShape = GameObject.FindGameObjectWithTag("shape");

    public static void incrementCount(int count)
    {
        scoreCount += count;
        if (scoreCount < 0)
            scoreCount = 0;
    }

}
