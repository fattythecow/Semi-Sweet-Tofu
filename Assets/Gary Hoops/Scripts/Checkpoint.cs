using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public static bool reachedCheckpoint = false;

	public static bool reachedCheckpoint2 = false;

	public static bool reachedCheckpoint3 = false;

	public static bool reachedcheckpoint4 = false;

	public static bool reachedcheckpoint5 = false;

	public static bool reachedcheckpoint6 = false;

	public static bool reachedcheckpoint7 = false;

	public static bool reachedcheckpoint8 = false;

	public static bool reachedcheckpoint9 = false;

	public static bool reachedcheckpoint10 = false;

	public static bool reachedcheckpoint11 = false;

	public static bool reachedcheckpoint12 = false;

	public static bool reachedcheckpoint13 = false;

	public static bool reachedcheckpoint14 = false;

	public static bool reachedcheckpoint15 = false;

	public static bool reachedcheckpoint16 = false;

	public static bool reachedcheckpoint17 = false;

	public static bool reachedcheckpoint18 = false;

	public static bool reachedcheckpoint19 = false;

	public static bool reachedcheckpoint20 = false;

	public static bool reachedcheckpoint21 = false;

	public static bool reachedcheckpoint22 = false;

	public static bool reachedcheckpoint23 = false;

	public static bool reachedcheckpoint24 = false;

	public static bool reachedcheckpoint25 = false;

	[SerializeField]
	string Checkpointnumber = "";

    void Start()
    {
		
    }
		
    void OnTriggerEnter(Collider other)
    {
		if(other.tag == "Player" && Checkpointnumber == "1")
        {
			reachedCheckpoint = true;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint1 reached!");
        }

		if (other.tag == "Player" && Checkpointnumber == "2") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = true;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint 2 reached!");
		}

		if (other.tag == "Player" && Checkpointnumber == "3") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = true;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint 3 reached!");
		}

		if (other.tag == "Player" && Checkpointnumber == "4") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = true;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint4 reached!");
		}

		if (other.tag == "Player" && Checkpointnumber == "5") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = true;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint5 reached!");
		}

		if (other.tag == "Player" && Checkpointnumber == "6") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = true;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint6 reached!");
		}

		if (other.tag == "Player" && Checkpointnumber == "7") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = true;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint7 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "8") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = true;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint8 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "9") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = true;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint9 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "10") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = true;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint10 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "11") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = true;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint11 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "12") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = true;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint12 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "13") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = true;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint13 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "14") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = true;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint14 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "15") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = true;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint15 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "16") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = true;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint16 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "17") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = true;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint17 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "18") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = true;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint18 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "19") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = true;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint19 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "20") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = true;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint20 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "21") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = true;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint21 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "22") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = true;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint22 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "23") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = true;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint23 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "24") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = true;
			reachedcheckpoint25 = false;
			Debug.Log ("checkpoint24 reached!");
		}
		if (other.tag == "Player" && Checkpointnumber == "25") {
			reachedCheckpoint = false;
			reachedCheckpoint2 = false;
			reachedCheckpoint3 = false;
			reachedcheckpoint4 = false;
			reachedcheckpoint5 = false;
			reachedcheckpoint6 = false;
			reachedcheckpoint7 = false;
			reachedcheckpoint8 = false;
			reachedcheckpoint9 = false;
			reachedcheckpoint10 = false;
			reachedcheckpoint11 = false;
			reachedcheckpoint12 = false;
			reachedcheckpoint13 = false;
			reachedcheckpoint14 = false;
			reachedcheckpoint15 = false;
			reachedcheckpoint16 = false;
			reachedcheckpoint17 = false;
			reachedcheckpoint18 = false;
			reachedcheckpoint19 = false;
			reachedcheckpoint20 = false;
			reachedcheckpoint21 = false;
			reachedcheckpoint22 = false;
			reachedcheckpoint23 = false;
			reachedcheckpoint24 = false;
			reachedcheckpoint25 = true;
			Debug.Log ("checkpoint25 reached!");
		}
	
    }

}
