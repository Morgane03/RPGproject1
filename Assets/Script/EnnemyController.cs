using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : MonoBehaviour
{
    public float totalHealth;
    public float currentHealth;
    public float xpGarented;
    public float atkDammage;
    public float atkSpeed;
    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit(float dommage)
    {
        currentHealth -= dommage;
    }
}
