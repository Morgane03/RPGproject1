using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : MonoBehaviour
{
    private ThirdPersonController[] players;

    public float totalHealth;
    public float currentHealth;
    public float expGarented;
    public float atkDammage;
    public float atkSpeed;
    public float MoveSpeed;

    private bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
    }

    public void GetHit(float dammage)
    {
        if (dead) return;
        currentHealth -= dammage;
        if (currentHealth < 0)
        {
            Die();
            return;
        }
        StartCoroutine(RecoverFromHit());
    }
    void Die()
    {
        dead = true;
        // animation mort
        DropLoop();
        foreach(ThirdPersonController pc in players)
        {
            pc.GetExperience(expGarented);
        }
        GameObject.Destroy(this.gameObject, 5);
    }

    void DropLoop()
    {
        print("You get the bounty");
    }

    IEnumerator RecoverFromHit()
    {
        yield return new WaitForSeconds(0.1f);
        // animation degat
    }
}
