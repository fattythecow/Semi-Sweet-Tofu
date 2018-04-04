using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTutorial : MonoBehaviour
{

    public GameObject Wall;

    public GameObject Monster;

    static public bool monsterDestroy = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            monsterDestroy = true;
            Destroy(Wall);
            Destroy(Monster);
        }
    }
}
