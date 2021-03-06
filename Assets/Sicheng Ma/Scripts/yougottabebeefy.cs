﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class yougottabebeefy : MonoBehaviour {


	enum MonsterStates{
		Patrol,
		Chase,
		BacktoPoint,

		NUM_STATES
	}

	private MonsterStates curState = MonsterStates.Patrol;

	private Dictionary<MonsterStates, Action> fsm = new Dictionary<MonsterStates, Action> ();

	private TryToGITGUDAI taco;

	public bool reverseMove = false;

	private float startTime;

	private float journeyLength;  

	public float speed;

	public GameObject pointA;

	public GameObject pointB;

	public bool facingleft;

	public Transform sightStart, sightEnd;

	public bool spotted = false;

	public GameObject target;

	public float moveSpeed = 3f;

	public GameObject spottedSign;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		target = GameObject.FindWithTag ("Player");
		journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
		taco = gameObject.GetComponent<TryToGITGUDAI> ();
		fsm.Add (MonsterStates.Patrol, new Action(StatePatrol));
		fsm.Add (MonsterStates.Chase, new Action(StateChase));
		fsm.Add (MonsterStates.BacktoPoint, new Action(StateBacktoPoint));

		SetState (MonsterStates.Patrol);


	}

	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (shop.isopen == false) {
			fsm [curState].Invoke ();
			RayCasting ();
		}
	}

	void RayCasting()
	{
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);

		spotted = Physics.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Player"));
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Water") {
			moveSpeed = 1.5f;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "Water") {
			moveSpeed = 3f;
		}
	}

	void SetState(MonsterStates newState){
		curState = newState;
	}

	void StatePatrol(){
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;


		facingleft = !facingleft;

		if (facingleft) {
			transform.eulerAngles = new Vector3 (0, -90, 0);
		} else {
			transform.eulerAngles = new Vector3 (0, 90, 0);
		}

		if (reverseMove) 
		{
			transform.position = Vector3.Lerp (pointB.transform.position, pointA.transform.position, fracJourney);
			facingleft = false;
		} 
		else 
		{
			transform.position = Vector3.Lerp (pointA.transform.position, pointB.transform.position, fracJourney);
			facingleft = true;
		}


		if ((Vector3.Distance (transform.position, pointA.transform.position) == 0f) || (Vector3.Distance (transform.position, pointB.transform.position) == 0f)) 
		{
			if (reverseMove)
			{
				reverseMove = false;
			} else 

			{
				reverseMove = true;
			}

			startTime = Time.time;
		}

		if (spotted) {
			SetState (MonsterStates.Chase);
			taco.ResetTimeSinceLastTransition ();
		}
	}

	void StateChase(){
		spottedSign.SetActive (true);

		transform.position = Vector3.MoveTowards (transform.position, new Vector2(target.transform.position.x, transform.position.y), moveSpeed * Time.deltaTime);

		if (!spotted)
		{
			SetState (MonsterStates.BacktoPoint);
			taco.ResetTimeSinceLastTransition ();
		}

	}

	void StateBacktoPoint(){

		spottedSign.SetActive (false);

		if (reverseMove){
			transform.position = Vector3.MoveTowards (transform.position, pointA.transform.position, moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, -90, 0);
			if ((Vector3.Distance (transform.position, pointA.transform.position) <= 0.5f)) {
				SetState (MonsterStates.Patrol);
				taco.ResetTimeSinceLastTransition ();
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, pointB.transform.position, moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3 (0, 90, 0);
			if ((Vector3.Distance (transform.position, pointB.transform.position) <= 0.5f)) {
				SetState (MonsterStates.Patrol);
				taco.ResetTimeSinceLastTransition ();
			}
		}


	}
}
