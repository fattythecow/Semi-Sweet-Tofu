using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTutorial : MonoBehaviour
{

    public GameObject Wall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject p1 = GameObject.FindWithTag("Player");
        CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools>();

        if (Player.IsGreen == true)
        {
            Destroy(Wall, 0);
        }
    }


    void OnTriggerEnter(Collider other)
    {

    }
}
