using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class MoonsterText : MonoBehaviour
{

    public GameObject greenText;

    public float timer = 0;

	public GameObject triggerMonster;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (greenText.gameObject.activeInHierarchy)
        {
            timer += Time.deltaTime;
            if (timer >= 4f)
            {
                greenText.SetActive(false);
				triggerMonster.SetActive (false);
                timer = 0;
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            greenText.SetActive(true);
        }
    }
}
