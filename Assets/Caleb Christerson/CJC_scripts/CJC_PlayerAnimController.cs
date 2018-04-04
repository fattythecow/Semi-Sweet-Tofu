using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PlayerAnimController : MonoBehaviour {

	[SerializeField]
	GameObject PlayerAnimHolder = null;
	[SerializeField]
	GameObject tofubody = null;
	[SerializeField]
	GameObject leftleg = null;
	[SerializeField]
	GameObject rightleg = null;
	private Animator characteranim;
	private bool animIdle;
	private bool animfaceleft;
	private bool animfaceright;
	private bool animjump;
	private bool animjumpleft;
	private bool animwalkleft;
	private bool animwalkright;
	private bool animdropleft;
	private bool animdropright;
	private bool animeatleft;
	private bool animeatright;
	private bool animclimbleft;
	private bool animclimbright;
	private bool animswimleft;
	private bool animswimright;
	private bool animshootleft;
	private bool animshootright;
	private bool animDeathLeft;
	private bool animDeathRight;
	private bool animSprintLeft;
	private bool animSprintRight;
	public bool animCompletedLevel;
	public bool completedLevelanimation = false;

	private float droptimer = 0;
	private float dropmax = .1f;
	public bool isdropping = false;

	private float eattimer = 0;
	private float eatmax = .85f;
	public bool iseating = false;

	private float shoottimer = 0;
	private float shootmax = .2f;
	public bool isshooting = false;

	public GameObject a;
	public GameObject b;

	// Use this for initialization
	void Start () {
		
		animCompletedLevel = false;
		completedLevelanimation = false;
		characteranim = PlayerAnimHolder.GetComponent<Animator> ();

	}

	public void completedLevelShit()
	{
		completedLevelanimation = true;
	}


	// Update is called once per frame
	void Update () {
		//GetAnimBools ();
		//if (!CJC_InGameXboxUISelector.hastoshowcontrols && !CJC_ButtonPressFIX.nocontrols) {
			manageanimbuttons ();
			ManageAnimBools ();
		if (!a.activeInHierarchy && !b.activeInHierarchy) {
			DoAnimations ();
		}
	}

	void GetAnimBools()
	{
		animIdle = characteranim.GetBool ("TofuIdle");
		animfaceleft = characteranim.GetBool ("FaceLeft");
		animfaceright = characteranim.GetBool ("FaceRight");
		animjump = characteranim.GetBool ("TofuJump");
		animjumpleft = characteranim.GetBool ("TofuJumpLeft");
		animwalkleft = characteranim.GetBool ("Walkleft");
		animwalkright = characteranim.GetBool ("WalkRight");
		animdropleft = characteranim.GetBool ("DropLeft");
		animdropright = characteranim.GetBool ("DropRight");
		animeatleft = characteranim.GetBool ("EatLeft");
		animeatright = characteranim.GetBool ("EatRight");
		animclimbleft = characteranim.GetBool ("ClimbLeft");
		animclimbright = characteranim.GetBool ("ClimbRight");
		animswimleft = characteranim.GetBool ("WaterLeft");
		animswimright = characteranim.GetBool ("WaterRight");
		animshootleft = characteranim.GetBool ("ShootLeft");
		animshootright = characteranim.GetBool ("ShootRight");
	}

	void manageanimbuttons()
	{
		GameObject jum = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = jum.GetComponent<CJC_tryjumping> ();
		GameObject dir = GameObject.Find ("nose");
		CJC_ShowDirection direction = dir.GetComponent<CJC_ShowDirection> ();
		GameObject p1 = GameObject.Find ("Ladder");
		Ladder climb = p1.GetComponent<Ladder> ();
		GameObject fruity = GameObject.FindWithTag ("Player");
		PlayerwithFruit fruit = fruity.GetComponent<PlayerwithFruit> ();

		if (iseating)
		{
			eattimer += Time.deltaTime;

			if (eattimer >= eatmax)
			{
				iseating = false;
				eattimer = 0;
			}
		}

		if (isdropping)
		{
			droptimer += Time.deltaTime;

			if (droptimer >= dropmax)
			{
				isdropping = false;
				droptimer = 0;
			}
		}

		if (isshooting)
		{
			shoottimer += Time.deltaTime;

			if (shoottimer >= shootmax)
			{
				isshooting = false;
				shoottimer = 0;
			}
		}
	}

	void ManageAnimBools()
	{
		if (animCompletedLevel)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", true);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animDeathLeft)
		{
			//Debug.Log ("animating idle");
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", true);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animDeathRight)
		{
			//Debug.Log ("animating idle");
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", true);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animIdle)
		{
			//Debug.Log ("animating idle");
			characteranim.SetBool ("TofuIdle", true);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animfaceleft)
		{
			//Debug.Log ("animating facing left");
			characteranim.SetBool ("FaceLeft", true);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animfaceright)
		{
			//Debug.Log ("animating facing right");
			characteranim.SetBool ("FaceRight", true);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animjump)
		{
			//Debug.Log ("animating jumping");
			characteranim.SetBool ("TofuJump", true);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animwalkleft)
		{
			//Debug.Log ("animating moving left");
			characteranim.SetBool ("Walkleft", true);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animwalkright)
		{
			//Debug.Log ("animating moving right");
			characteranim.SetBool ("WalkRight", true);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animSprintLeft)
		{
			//Debug.Log ("animating moving left");
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", true);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animSprintRight)
		{
			//Debug.Log ("animating moving right");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", true);
		}
		else if (animjumpleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", true);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animdropleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", true);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animdropright)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", true);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animeatleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", true);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animeatright)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", true);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animclimbleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", true);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animclimbright)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", true);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animswimleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", true);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animswimright)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", true);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animshootleft)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", true);
			characteranim.SetBool ("ShootRight", false);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
		else if (animshootright)
		{
			//Debug.Log ("animating jumping left");
			characteranim.SetBool ("WalkRight", false);
			characteranim.SetBool ("TofuIdle", false);
			characteranim.SetBool ("FaceLeft", false);
			characteranim.SetBool ("FaceRight", false);
			characteranim.SetBool ("TofuJump", false);
			characteranim.SetBool ("TofuJumpLeft", false);
			characteranim.SetBool ("Walkleft", false);
			characteranim.SetBool ("DropLeft", false);
			characteranim.SetBool ("DropRight", false);
			characteranim.SetBool ("EatLeft", false);
			characteranim.SetBool ("EatRight", false);
			characteranim.SetBool ("ClimbLeft", false);
			characteranim.SetBool ("ClimbRight", false);
			characteranim.SetBool ("WaterLeft", false);
			characteranim.SetBool ("WaterRight", false);
			characteranim.SetBool ("ShootLeft", false);
			characteranim.SetBool ("ShootRight", true);
			characteranim.SetBool ("DeathLeft", false);
			characteranim.SetBool ("DeathRight", false);
			characteranim.SetBool ("CompletedLevelRight", false);
			characteranim.SetBool ("SprintLeft", false);
			characteranim.SetBool ("SprintRight", false);
		}
	}

	void DoAnimations()
	{
		GameObject jum = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = jum.GetComponent<CJC_tryjumping> ();

		GameObject dir = GameObject.Find ("nose");
		CJC_ShowDirection direction = dir.GetComponent<CJC_ShowDirection> ();

		GameObject p1 = GameObject.Find ("Ladder");
		Ladder climb = p1.GetComponent<Ladder> ();

		GameObject fruity = GameObject.FindWithTag ("Player");
		PlayerwithFruit fruit = fruity.GetComponent<PlayerwithFruit> ();

		GameObject jumpp = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = jumpp.GetComponent<CJC_PlayerAndBools> ();



		if (direction.facingleft)
		{
			//Debug.Log ("making him face left");
			tofubody.transform.rotation = new Quaternion (tofubody.transform.rotation.x, 0, tofubody.transform.rotation.z, 1);
			leftleg.transform.rotation = new Quaternion (leftleg.transform.rotation.x, 0,leftleg.transform.rotation.z, 1);
			rightleg.transform.rotation = new Quaternion (rightleg.transform.rotation.x, 0, rightleg.transform.rotation.z, 1);
		}
		else if (direction.facingright)
		{
			//Debug.Log ("making him face right");
			//tofubody.transform.rotation = new Quaternion (tofubody.transform.rotation.x, 180, tofubody.transform.rotation.z,1);
			//leftleg.transform.rotation = new Quaternion (leftleg.transform.rotation.x, 180,leftleg.transform.rotation.z,1);
			//rightleg.transform.rotation = new Quaternion (rightleg.transform.rotation.x, 180, rightleg.transform.rotation.z, 1);

		}

		if (animCompletedLevel)//completed level
		{
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = true;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		if (player.PlayerDied && direction.facingleft && !animCompletedLevel)//death left
		{
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = true;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		else if (player.PlayerDied && direction.facingright && !animCompletedLevel)//death right
		{
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = true;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		//for player dropping a fruit to the left
		else if (jump.PlayerInWater && direction.facingleft && !isshooting && !iseating && !player.PlayerDied && !animCompletedLevel) // for player being in water and facing left
		{
			//Debug.Log ("swim left");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = true;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (Input.GetAxis ("Horizontal") < 0) { //moving down
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Horizontal") > .1f) { // moving up
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Horizontal") < .1f && Input.GetAxis ("Horizontal") > -.1f) {
				characteranim.speed = 0;
			}
		}
		else if (jump.PlayerInWater && direction.facingright && !isshooting && !iseating && !player.PlayerDied && !animCompletedLevel) // for player being in water and facing right
		{
			//Debug.Log ("swim right");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright =true;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (Input.GetAxis ("Horizontal") < 0) { //moving down
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Horizontal") > .1f) { // moving up
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Horizontal") < .1f && Input.GetAxis ("Horizontal") > -.1f) {
				characteranim.speed = 0;
			}
		}
		else if (direction.facingleft && isshooting && !jump.PlayerInWater && !player.PlayerDied && !animCompletedLevel) //  for player shooting left
		{
			//Debug.Log ("shoot left");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = true;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		else if (direction.facingright && isshooting && !jump.PlayerInWater && !player.PlayerDied && !animCompletedLevel) //  for player shooting right
		{
			//Debug.Log ("shoot right");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = true;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		else if (direction.facingleft && isdropping && !Ladder.willClimb && !jump.PlayerInWater  && !isshooting && !iseating&& !player.PlayerDied && !animCompletedLevel) { //for player dropping left
			//Debug.Log ("drop left");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = true;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		} 
		else if (direction.facingright && isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !iseating && !player.PlayerDied && !animCompletedLevel)
		{ //for player dropping a fruit to the right
			//Debug.Log ("drop right");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = true;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		} 
		else if (direction.facingright && iseating && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel) {//for player eat a fruit to the right
			//Debug.Log ("eat right");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = true;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		} 
		else if (direction.facingleft && iseating && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel)
		{//for player eat a fruit to the left
			//Debug.Log ("eat right");
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = true;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		//if player is not moving left or right
		else if (Input.GetAxis ("Horizontal") == 0 && player.OnGround && !direction.facingleft && !direction.facingright && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel)
		{
			//Debug.Log ("idle");
			animIdle = true;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		} 
		else if (direction.facingleft && Input.GetAxis ("Horizontal") == 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel)
		{ //facing left idle
			animIdle = false;
			animfaceleft = true;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		}
		else if (direction.facingright && Input.GetAxis ("Horizontal") == 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel)
		{ //facing right idle
			animIdle = false;
			animfaceleft = false;
			animfaceright = true;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;
			characteranim.speed = 1;
		} 
		else if (jump.movedirection.x < 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel && !player.IsSprinting)
		{//moving left anim
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = true;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (!player.IsYellow)
			{
				characteranim.speed = 1;

			}
			else if (player.IsYellow)
			{

				characteranim.speed = 1.15f;
			}
		} 
		else if (jump.movedirection.x > 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel && !player.IsSprinting)
		{//moving right anim
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = true;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (!player.IsYellow)
			{
					characteranim.speed = 1;

			}
			else if (player.IsYellow)
			{
				
					characteranim.speed = 1.15f;
			}
		} 
		else if (jump.movedirection.x < 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel && player.IsSprinting)
		{//sprinting left anim
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = true;
			animSprintRight = false;

			if (!player.IsYellow)
			{
				characteranim.speed = 1;

			}
			else if (player.IsYellow)
			{

				characteranim.speed = 1.15f;
			}
		} 
		else if (jump.movedirection.x > 0 && player.OnGround && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel && player.IsSprinting)
		{//sprinting right anim
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = true;

			if (!player.IsYellow)
			{
				characteranim.speed = 1;

			}
			else if (player.IsYellow)
			{

				characteranim.speed = 1.15f;
			}
		} 
		else if (Ladder.willClimb && direction.facingleft && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel) { // for player on ladder facing left

			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = true;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (Input.GetAxis ("Vertical") < 0) { //moving down
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Vertical") > .1f) { // moving up
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Vertical") < .1f && Input.GetAxis ("Vertical") > -.1f) {
				characteranim.speed = 0;
			}
		} 
		else if (Ladder.willClimb && direction.facingright && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel) { // for player on ladder facing right

			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = true;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (Input.GetAxis ("Vertical") < 0) { //moving down
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Vertical") > .1f) { // moving up
				characteranim.speed = 1;
			} else if (Input.GetAxis ("Vertical") < .1f && Input.GetAxis ("Vertical") > -.1f) {
				characteranim.speed = 0;
			}
		} 
		else if (!player.OnGround && direction.facingright && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel) { //for player jumping right
			
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = true;
			animjumpleft = false;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (player.IsSprinting) {
				characteranim.speed = 3;
			} else if (!player.IsSprinting) {
				characteranim.speed = 1;
			}
		} 
		else if (!player.OnGround && direction.facingleft && !isdropping && !Ladder.willClimb && !jump.PlayerInWater && !isshooting && !player.PlayerDied && !animCompletedLevel) { // for player jumping left//if in air and facing right do jump left anim
			
			animIdle = false;
			animfaceleft = false;
			animfaceright = false;
			animwalkleft = false;
			animwalkright = false;
			animjump = false;
			animjumpleft = true;
			animdropleft = false;
			animdropright = false;
			animeatleft = false;
			animeatright = false;
			animclimbleft = false;
			animclimbright = false;
			animswimleft = false;
			animswimright = false;
			animshootleft = false;
			animshootright = false;
			animDeathLeft = false;
			animDeathRight = false;
			animCompletedLevel = false;
			animSprintLeft = false;
			animSprintRight = false;

			if (player.IsSprinting) {
				characteranim.speed = 3;
			} else if (!player.IsSprinting) {
				characteranim.speed = 1;
			}
		} 





	}

}
