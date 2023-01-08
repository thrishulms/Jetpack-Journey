using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerDeathCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        var deathPage = Instantiate(playerDeathCanvas);
        // deathPage.SetActive(true);
        Time.timeScale = 0;
    }
}
