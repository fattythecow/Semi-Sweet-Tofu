using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CJC_FishyAI : MonoBehaviour {

	enum FishStates{
		Patrol,
		Chase,
		BacktoPoint,

		NUM_STATES
	}

	private FishStates curState = FishStates.Patrol;

	private Dictionary<FishStates, Action> fsm = new Dictionary<FishStates, Action> ();

	private TryToGITGUDAI taco;

	public bool movetoA = false;

	private float startTime;

	private float journeyLength;  

	public float speed;

	public GameObject pointA;

	public GameObject pointB;

	public bool facingleft;

	public GameObject target;

	public float moveSpeed = 2f;

	public GameObject spottedSign;

	public CJC_InWater p1;

	[SerializeField]
	Material normalfish;
	[SerializeField]
	Material angryfish;

	[SerializeField]
	GameObject fish1;
	[SerializeField]
	GameObject fish2;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		target = GameObject.FindWithTag ("Player");
		journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
		taco = gameObject.GetComponent<TryToGITGUDAI> ();
		fsm.Add (FishStates.Patrol, new Action(StatePatrol));
		fsm.Add (FishStates.Chase, new Action(StateChase));
		fsm.Add (FishStates.BacktoPoint, new Action(StateBacktoPoint));

		SetState (FishStates.Patrol);


	}

	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false) {

			fsm [curState].Invoke ();
		}
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Water") {
			moveSpeed = 2f;
		}
	}

	void SetState(FishStates newState){
		curState = newState;
	}

	void StatePatrol(){
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		fish1.GetComponent<MeshRenderer> ().material = normalfish;
		fish2.GetComponent<MeshRenderer> ().material = normalfish;

		facingleft = !facingleft;

		if (facingleft) {
			transform.eulerAngles = new Vector3 (0, 0, 0);
		} else {
			transform.eulerAngles = new Vector3 (0, -180, 0);
		}

		if (movetoA) 
		{
			transform.position = Vector3.Lerp (pointB.transform.position, pointA.transform.position, fracJourney);
			facingleft = false;
		} 
		else
		{
			transform.position = Vector3.Lerp (pointA.transform.position, pointB.transform.position, fracJourney);
			facingleft = true;
		}


		if ((Vector3.Distance (transform.position, pointA.transform.position) == 0.0f) || (Vector3.Distance (transform.position, pointB.transform.position) == 0.0f)) 
		{
			if (movetoA)
			{
				movetoA = false;
			} else {
				movetoA = true;
			}

			startTime = Time.time;
		}

		if (jump.PlayerInWater) {
			SetState (FishStates.Chase);
			taco.ResetTimeSinceLastTransition ();
		}
	}

	void StateChase(){
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();
		spottedSign.SetActive (true);
		fish1.GetComponent<MeshRenderer> ().material = angryfish;
		fish2.GetComponent<MeshRenderer> ().material = angryfish;
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, moveSpeed * Time.deltaTime);
		if (transform.position.x > target.transform.position.x) {
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}else
			transform.eulerAngles = new Vector3 (0, -180, 0);
			
		if (!jump.PlayerInWater) {
			SetState (FishStates.BacktoPoint);
			taco.ResetTimeSinceLastTransition ();
		}
	}

	void StateBacktoPoint()
	{
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();

		spottedSign.SetActive (false);

		if (movetoA){
			transform.position = Vector3.MoveTowards (transform.position, pointA.transform.position, moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 0, 0);
			if ((Vector3.Distance (transform.position, pointA.transform.position) <= 0.5f)){
				SetState (FishStates.Patrol);
				taco.ResetTimeSinceLastTransition ();
			}
			if (jump.PlayerInWater) {
				SetState (FishStates.Chase);
				taco.ResetTimeSinceLastTransition ();
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, pointB.transform.position, moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, -180, 0);
			if (Vector3.Distance(transform.position, pointB.transform.position) <= 0.5f){
				SetState (FishStates.Patrol);
				taco.ResetTimeSinceLastTransition ();
			}

			if (jump.PlayerInWater) {
				SetState (FishStates.Chase);
				taco.ResetTimeSinceLastTransition ();
			}
		}
	}
}
