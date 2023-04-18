using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Timeline : MonoBehaviour
{
    public float timeRemaining;
    public GameObject BG;
    public GameObject text;
    public GameObject text2;
    public GameObject button;
    public int levelNo;
    void Start()
    {
        BG.SetActive(true);
        text.SetActive(true);
        button.SetActive(false);
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

        }
        if (timeRemaining < 0)
        {
            BG.SetActive(false);
            text.SetActive(false);
            text2.SetActive(false);
            button.SetActive(true);
        }
    }

    public void Nextlevel()
    {
        SceneManager.LoadScene(levelNo);
    }

    
}
