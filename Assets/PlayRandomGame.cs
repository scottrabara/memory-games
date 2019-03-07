using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PlayRandomGame : MonoBehaviour
{

    public void PlayRandomScene()
    {
        var sceneIndex = Random.Range(1, 4);

        SceneManager.LoadScene(sceneIndex);
    }
}
