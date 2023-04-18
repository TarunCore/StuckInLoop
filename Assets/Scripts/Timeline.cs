using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeline : MonoBehaviour
{
    public float timeRemaining;
    public GameObject year;
    public GameObject Black;
    public GameObject GaS;
    public GameObject[] Birds;


    // Start is called before the first frame update
    void Start()
    {
        Birds = GameObject.FindGameObjectsWithTag("Bird");
        foreach (GameObject bird in Birds)
        {
            bird.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining>0)
        {
            timeRemaining -= Time.deltaTime;
            
        }
        if (timeRemaining < 0)
        {
            year.SetActive(false);
            Black.SetActive(false);
            GaS.SetActive(false);
            foreach (GameObject bird in Birds)
            {
                bird.SetActive(true);
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
