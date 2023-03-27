using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCreatureTrajet : MonoBehaviour
{
    public float speed;

    public Transform target;
    public Transform follow;
    public Transform[] points;

    private int WeipointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        target = points[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);

        if ((Vector3.Distance(transform.position, target.position) <= 0.2))
        {
            GetNextWeipont();
        }
    }

    void GetNextWeipont()
    {
        WeipointIndex++;
        target = points[WeipointIndex];

        if (WeipointIndex == 7)
        {
            WeipointIndex = 0;
        }
    }


    void Rotation()
    {
        transform.Rotate(Vector3.left * Time.deltaTime);
        transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime);
        transform.Rotate(Vector3.down * Time.deltaTime);
        transform.Rotate(Vector3.forward * Time.deltaTime);
        transform.Rotate(Vector3.back * Time.deltaTime);
    }

}
