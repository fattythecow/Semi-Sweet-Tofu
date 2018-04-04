using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChargingAI : MonoBehaviour {

	[SerializeField]
	GameObject ChargerAnimHolder = null;
	private Animator chargeanim = null;

	bool Stunned = false;
	float MaxStunTimer = 1f;
	float CurStunTimer = 0;

	enum MonsterChargingStates{
		Looking,
		Chase,
		BacktoLooking,

		NUM_STATES
	}

	private MonsterChargingStates curState = MonsterChargingStates.Looking;

	private Dictionary<MonsterChargingStates, Action> fsm = new Dictionary<MonsterChargingStates, Action> ();

	private TryToGITGUDAI taco;

	public Transform sightStart, sightEnd;

	public bool spotted = false;

	public GameObject target;

	public float moveSpeed = 3f;

	public GameObject spottedSign;

	public bool facingleft;

	public float startTime;

	// Use this for initialization
	void Start () {
		chargeanim = ChargerAnimHolder.GetComponent<Animator> ();
		target = GameObject.FindWithTag ("Player");
		taco = gameObject.GetComponent<TryToGITGUDAI> ();
		fsm.Add (MonsterChargingStates.Looking, new Action(StateLooking));
		fsm.Add (MonsterChargingStates.Chase, new Action(StateChase));
		fsm.Add (MonsterChargingStates.BacktoLooking, new Action(StateBacktoLooking));

		SetState (MonsterChargingStates.Looking);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false) {
			ManageStunned ();
			fsm [curState].Invoke ();
			RayCasting ();
			startTime += Time.deltaTime;
		}
	}


	void ManageStunned()
	{
		if (Stunned)
		{
			moveSpeed = 0;
			CurStunTimer += Time.deltaTime;
			if (CurStunTimer >= MaxStunTimer)
			{
				Stunned = false;
				CurStunTimer = 0;
			}
		}
		else if (!Stunned)
		{
			moveSpeed = 8;
			CurStunTimer = 0;
		}
	}

	void RayCasting()
	{
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);
		spotted = Physics.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Player"));
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerProjectile") 
		{
			Stunned = true;
			//health -= damagefromProjectile;
		}
	}
	void OnTriggerStay(Collider other){
		//if (other.name == "Water") {
		//	moveSpeed = 1.5f;
		//}
	}

	void OnTriggerExit(Collider other){
		//if (other.name == "Water") {
		//	moveSpeed = 3f;
		//}
	}

	void SetState(MonsterChargingStates newState){
		curState = newState;
	}

	void StateLooking(){

		chargeanim.SetBool ("IsSearching", true);
		chargeanim.SetBool ("IsReseting", false);
		chargeanim.SetBool ("IsCharging", false);

		if (facingleft) {
			transform.eulerAngles = new Vector3 (0, -90, 0);
		} else {
			transform.eulerAngles = new Vector3 (0, 90, 0);
		}
			
		if (startTime >= 3) {
			if (facingleft) {
				facingleft = false;
				startTime = 0;
			} else {
				facingleft = true;
				startTime = 0;
			}
		}

		if (spotted) {
			SetState (MonsterChargingStates.Chase);
			taco.ResetTimeSinceLastTransition ();
			startTime = 0;
		}

	}

	void StateChase(){
		chargeanim.SetBool ("IsSearching", false);
		chargeanim.SetBool ("IsReseting", false);
		chargeanim.SetBool ("IsCharging",true);
		spottedSign.SetActive (true);
		if (startTime >= 0.5f) {
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, moveSpeed * Time.deltaTime);
		}

		if (!spotted) {
			SetState (MonsterChargingStates.BacktoLooking);
			taco.ResetTimeSinceLastTransition ();
			startTime = 0;
		}
	}

	void StateBacktoLooking(){
		chargeanim.SetBool ("IsSearching", false);
		chargeanim.SetBool ("IsReseting", true);
		chargeanim.SetBool ("IsCharging",false);
		spottedSign.SetActive (false);
		if (startTime >= 2) {
			SetState (MonsterChargingStates.Looking);
			taco.ResetTimeSinceLastTransition ();
		}

	}
}
