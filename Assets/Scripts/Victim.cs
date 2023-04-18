using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victim : MonoBehaviour
{
    public int FamilyHealth;
    public int Damage;
    public Text Health;
    public GameObject PopUpOndeath;
    public GameObject character1;
    public HealthBar healthBar;
    public GameObject[] Birds;
    public AudioSource damagesound;


    void Start()
    {
        healthBar.SetMaxHealth(FamilyHealth);
        damagesound = GetComponent<AudioSource>();
        PopUpOndeath.SetActive(false);
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bird"))
        {
            FamilyHealth -= Damage;
            damagesound.Play();
            if (FamilyHealth <=0)
            {
                Debug.Log("loss");
                character1.SetActive(false);
                PopUpOndeath.SetActive(true);                
            }
        }
    }

    void Update()
    {
        Health.text = "Health: " + FamilyHealth.ToString();
        healthBar.SetHealth(FamilyHealth);
    }
}
