using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_CameraHorizontalMove : MonoBehaviour
{
	[SerializeField]
	GameObject target = null;
	[SerializeField]
	float offset;
	[SerializeField]
	float HIghLimit;
	[SerializeField]
	float LowLimit;

	bool isEmpty = true;

	float cameraAdjusting =0;
	public float maxAdjustTime = 1;
	[SerializeField]
	bool hasAdjustedOnce = false;
	float inCollTimer = 0;

	float EnteredColl = 0;



	// Use this for initialization
	void Start ()
	{
		gameObject.transform.position = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//target.transform.position = new Vector3 (target.transform.localPosition.x,4.55f,-21);
		DoMovement ();


	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") 
		{
			EnteredColl += Time.deltaTime;

			if (EnteredColl >= 2)
			{
				EnteredColl = 0;
				isEmpty = false;
			}
		}


	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			EnteredColl = 0;
			cameraAdjusting = 0;
			inCollTimer = 0;
			hasAdjustedOnce = false;
			isEmpty = true;
		}
	}

	void DoMovement()
	{	GameObject jump = GameObject.FindWithTag ("Player");
		CJC_tryjumping jumper = jump.GetComponent<CJC_tryjumping> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		/*if (target.transform.position.y > HIghLimit) 
		{
			gameObject.transform.position = new Vector3 (target.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
			Debug.Log ("player too high to follow");
		} 
		else if (target.transform.position.y < LowLimit)
		{
			gameObject.transform.position = new Vector3 (target.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
			Debug.Log ("player too low to follow");
		}
		else if (target.transform.position.y > LowLimit && target.transform.position.y < HIghLimit)
			gameObject.transform.position = Vector3.Lerp (transform.position, target.transform.position, offset);*/

		/*if (!jumper.contorller.isGrounded && jumper.movedirection.y <= -5)
		{
			target.transform.position = new Vector3 (target.transform.position.x,player.transform.position.y,transform.position.z);
			offset = .04f;
			gameObject.transform.position = Vector3.Lerp (transform.position, target.transform.position, offset);
		} 
		else 
		{*/
			//target.transform.position = new Vector3 (target.transform.position.x,player.transform.position.y + 3.72f,transform.position.z);

			if (isEmpty == true)
			{
				offset = .05f;
				gameObject.transform.position = Vector3.Lerp (transform.position, target.transform.position, offset);
			} 
			else if (isEmpty == false)
			{
				inCollTimer += Time.deltaTime;

				if (inCollTimer >= 3 && hasAdjustedOnce == false)
				{
					gameObject.transform.position = Vector3.Lerp (transform.position, target.transform.position, offset);
					cameraAdjusting += Time.deltaTime;

					if (cameraAdjusting >= maxAdjustTime)
					{
						cameraAdjusting = 0;
						inCollTimer = 0;
						hasAdjustedOnce = true;
					}
				}
			}
		//}
	}
}
