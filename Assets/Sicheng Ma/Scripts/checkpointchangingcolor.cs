using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointchangingcolor : MonoBehaviour {

	private GameObject check1;
	private GameObject check2;
	private GameObject check3;
	private GameObject check4;
	private GameObject check5;
	private GameObject check6;
	private GameObject check7;
	private GameObject check8;
	private GameObject check9;
	private GameObject check10;
	private GameObject check11;
	private GameObject check12;
	private GameObject check13;
	private GameObject check14;
	private GameObject check15;
	private GameObject check16;
	private GameObject check17;
	private GameObject check18;
	private GameObject check19;
	private GameObject check20;
	private GameObject check21;
	private GameObject check22;
	private GameObject check23;
	private GameObject check24;
	private GameObject check25;
	public Material redflag;
	public Material yelflag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Handleflagcolor ();

	}

	void Handleflagcolor(){
		if (Checkpoint.reachedcheckpoint25) {
			check25 = GameObject.Find ("Checkpoint25");
			GetComponent<Renderer> ().material = redflag;

		}

		else if (Checkpoint.reachedCheckpoint) {
			check1 = GameObject.Find ("Checkpoint");
			check2 = GameObject.Find ("Checkpoint2");
			check1.GetComponent<Renderer> ().material = redflag;
			check2.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedCheckpoint2) {
			check1 = GameObject.Find ("Checkpoint");
			check2 = GameObject.Find ("Checkpoint2");
			check1.GetComponent<Renderer> ().material = yelflag;
			check2.GetComponent<Renderer> ().material = redflag;
		}



		else if (Checkpoint.reachedCheckpoint3) {
			check3 = GameObject.Find ("Checkpoint3");
			check4 = GameObject.Find ("Checkpoint4");
			check5 = GameObject.Find ("Checkpoint5");
			check6 = GameObject.Find ("Checkpoint6");
			check3.GetComponent<Renderer> ().material = redflag;
			check4.GetComponent<Renderer> ().material = yelflag;
			check5.GetComponent<Renderer> ().material = yelflag;
			check6.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint4) {
			check3 = GameObject.Find ("Checkpoint3");
			check4 = GameObject.Find ("Checkpoint4");
			check5 = GameObject.Find ("Checkpoint5");
			check6 = GameObject.Find ("Checkpoint6");
			check3.GetComponent<Renderer> ().material = yelflag;
			check4.GetComponent<Renderer> ().material = redflag;
			check5.GetComponent<Renderer> ().material = yelflag;
			check6.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint5) {
			check3 = GameObject.Find ("Checkpoint3");
			check4 = GameObject.Find ("Checkpoint4");
			check5 = GameObject.Find ("Checkpoint5");
			check6 = GameObject.Find ("Checkpoint6");
			check3.GetComponent<Renderer> ().material = yelflag;
			check4.GetComponent<Renderer> ().material = yelflag;
			check5.GetComponent<Renderer> ().material = redflag;
			check6.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint6) {
			check3 = GameObject.Find ("Checkpoint3");
			check4 = GameObject.Find ("Checkpoint4");
			check5 = GameObject.Find ("Checkpoint5");
			check6 = GameObject.Find ("Checkpoint6");
			check3.GetComponent<Renderer> ().material = yelflag;
			check4.GetComponent<Renderer> ().material = yelflag;
			check5.GetComponent<Renderer> ().material = yelflag;
			check6.GetComponent<Renderer> ().material = redflag;
		}




		else if (Checkpoint.reachedcheckpoint7) {
			check7 = GameObject.Find ("Checkpoint7");
			check8 = GameObject.Find ("Checkpoint8");
			check9 = GameObject.Find ("Checkpoint9");
			check10 = GameObject.Find ("Checkpoint10");
			check11 = GameObject.Find ("Checkpoint11");
			check7.GetComponent<Renderer> ().material = redflag;
			check8.GetComponent<Renderer> ().material = yelflag;
			check9.GetComponent<Renderer> ().material = yelflag;
			check10.GetComponent<Renderer> ().material = yelflag;
			check11.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint8) {
			check7 = GameObject.Find ("Checkpoint7");
			check8 = GameObject.Find ("Checkpoint8");
			check9 = GameObject.Find ("Checkpoint9");
			check10 = GameObject.Find ("Checkpoint10");
			check11 = GameObject.Find ("Checkpoint11");
			check7.GetComponent<Renderer> ().material = yelflag;
			check8.GetComponent<Renderer> ().material = redflag;
			check9.GetComponent<Renderer> ().material = yelflag;
			check10.GetComponent<Renderer> ().material = yelflag;
			check11.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint9) {
			check7 = GameObject.Find ("Checkpoint7");
			check8 = GameObject.Find ("Checkpoint8");
			check9 = GameObject.Find ("Checkpoint9");
			check10 = GameObject.Find ("Checkpoint10");
			check11 = GameObject.Find ("Checkpoint11");
			check7.GetComponent<Renderer> ().material = yelflag;
			check8.GetComponent<Renderer> ().material = yelflag;
			check9.GetComponent<Renderer> ().material = redflag;
			check10.GetComponent<Renderer> ().material = yelflag;
			check11.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint10) {
			check7 = GameObject.Find ("Checkpoint7");
			check8 = GameObject.Find ("Checkpoint8");
			check9 = GameObject.Find ("Checkpoint9");
			check10 = GameObject.Find ("Checkpoint10");
			check11 = GameObject.Find ("Checkpoint11");
			check7.GetComponent<Renderer> ().material = yelflag;
			check8.GetComponent<Renderer> ().material = yelflag;
			check9.GetComponent<Renderer> ().material = yelflag;
			check10.GetComponent<Renderer> ().material = redflag;
			check11.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint11) {
			check7 = GameObject.Find ("Checkpoint7");
			check8 = GameObject.Find ("Checkpoint8");
			check9 = GameObject.Find ("Checkpoint9");
			check10 = GameObject.Find ("Checkpoint10");
			check11 = GameObject.Find ("Checkpoint11");
			check7.GetComponent<Renderer> ().material = yelflag;
			check8.GetComponent<Renderer> ().material = yelflag;
			check9.GetComponent<Renderer> ().material = yelflag;
			check10.GetComponent<Renderer> ().material = yelflag;
			check11.GetComponent<Renderer> ().material = redflag;
		}




		else if (Checkpoint.reachedcheckpoint12) {
			check12 = GameObject.Find ("Checkpoint12");
			check13 = GameObject.Find ("Checkpoint13");
			check14 = GameObject.Find ("Checkpoint14");
			check15 = GameObject.Find ("Checkpoint15");
			check12.GetComponent<Renderer> ().material = redflag;
			check13.GetComponent<Renderer> ().material = yelflag;
			check14.GetComponent<Renderer> ().material = yelflag;
			check15.GetComponent<Renderer> ().material = yelflag;

		}

		else if (Checkpoint.reachedcheckpoint13) {
			check12 = GameObject.Find ("Checkpoint12");
			check13 = GameObject.Find ("Checkpoint13");
			check14 = GameObject.Find ("Checkpoint14");
			check15 = GameObject.Find ("Checkpoint15");
			check12.GetComponent<Renderer> ().material = yelflag;
			check13.GetComponent<Renderer> ().material = redflag;
			check14.GetComponent<Renderer> ().material = yelflag;
			check15.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint14) {
			check12 = GameObject.Find ("Checkpoint12");
			check13 = GameObject.Find ("Checkpoint13");
			check14 = GameObject.Find ("Checkpoint14");
			check15 = GameObject.Find ("Checkpoint15");
			check12.GetComponent<Renderer> ().material = yelflag;
			check13.GetComponent<Renderer> ().material = yelflag;
			check14.GetComponent<Renderer> ().material = redflag;
			check15.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint15) {
			check12 = GameObject.Find ("Checkpoint12");
			check13 = GameObject.Find ("Checkpoint13");
			check14 = GameObject.Find ("Checkpoint14");
			check15 = GameObject.Find ("Checkpoint15");
			check12.GetComponent<Renderer> ().material = yelflag;
			check13.GetComponent<Renderer> ().material = yelflag;
			check14.GetComponent<Renderer> ().material = yelflag;
			check15.GetComponent<Renderer> ().material = redflag;
		}





		else if (Checkpoint.reachedcheckpoint16) {
			check16 = GameObject.Find ("Checkpoint16");
			check17 = GameObject.Find ("Checkpoint17");
			check18 = GameObject.Find ("Checkpoint18");
			check19 = GameObject.Find ("Checkpoint19");
			check20 = GameObject.Find ("Checkpoint20");
			check16.GetComponent<Renderer> ().material = redflag;
			check17.GetComponent<Renderer> ().material = yelflag;
			check18.GetComponent<Renderer> ().material = yelflag;
			check19.GetComponent<Renderer> ().material = yelflag;
			check20.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint17) {
			check16 = GameObject.Find ("Checkpoint16");
			check17 = GameObject.Find ("Checkpoint17");
			check18 = GameObject.Find ("Checkpoint18");
			check19 = GameObject.Find ("Checkpoint19");
			check20 = GameObject.Find ("Checkpoint20");
			check16.GetComponent<Renderer> ().material = yelflag;
			check17.GetComponent<Renderer> ().material = redflag;
			check18.GetComponent<Renderer> ().material = yelflag;
			check19.GetComponent<Renderer> ().material = yelflag;
			check20.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint18) {
			check16 = GameObject.Find ("Checkpoint16");
			check17 = GameObject.Find ("Checkpoint17");
			check18 = GameObject.Find ("Checkpoint18");
			check19 = GameObject.Find ("Checkpoint19");
			check20 = GameObject.Find ("Checkpoint20");
			check16.GetComponent<Renderer> ().material = yelflag;
			check17.GetComponent<Renderer> ().material = yelflag;
			check18.GetComponent<Renderer> ().material = redflag;
			check19.GetComponent<Renderer> ().material = yelflag;
			check20.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint19) {
			check16 = GameObject.Find ("Checkpoint16");
			check17 = GameObject.Find ("Checkpoint17");
			check18 = GameObject.Find ("Checkpoint18");
			check19 = GameObject.Find ("Checkpoint19");
			check20 = GameObject.Find ("Checkpoint20");
			check16.GetComponent<Renderer> ().material = yelflag;
			check17.GetComponent<Renderer> ().material = yelflag;
			check18.GetComponent<Renderer> ().material = yelflag;
			check19.GetComponent<Renderer> ().material = redflag;
			check20.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint20) {
			check16 = GameObject.Find ("Checkpoint16");
			check17 = GameObject.Find ("Checkpoint17");
			check18 = GameObject.Find ("Checkpoint18");
			check19 = GameObject.Find ("Checkpoint19");
			check20 = GameObject.Find ("Checkpoint20");
			check16.GetComponent<Renderer> ().material = yelflag;
			check17.GetComponent<Renderer> ().material = yelflag;
			check18.GetComponent<Renderer> ().material = yelflag;
			check19.GetComponent<Renderer> ().material = yelflag;
			check20.GetComponent<Renderer> ().material = redflag;
		}



		else if (Checkpoint.reachedcheckpoint21) {
			check21 = GameObject.Find ("Checkpoint21");
			check22 = GameObject.Find ("Checkpoint22");
			check23 = GameObject.Find ("Checkpoint23");
			check24 = GameObject.Find ("Checkpoint24");
			check21.GetComponent<Renderer> ().material = redflag;
			check22.GetComponent<Renderer> ().material = yelflag;
			check23.GetComponent<Renderer> ().material = yelflag;
			check24.GetComponent<Renderer> ().material = yelflag;

		}

		else if (Checkpoint.reachedcheckpoint22) {
			check21 = GameObject.Find ("Checkpoint21");
			check22 = GameObject.Find ("Checkpoint22");
			check23 = GameObject.Find ("Checkpoint23");
			check24 = GameObject.Find ("Checkpoint24");
			check21.GetComponent<Renderer> ().material = yelflag;
			check22.GetComponent<Renderer> ().material = redflag;
			check23.GetComponent<Renderer> ().material = yelflag;
			check24.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint23) {
			check21 = GameObject.Find ("Checkpoint21");
			check22 = GameObject.Find ("Checkpoint22");
			check23 = GameObject.Find ("Checkpoint23");
			check24 = GameObject.Find ("Checkpoint24");
			check21.GetComponent<Renderer> ().material = yelflag;
			check22.GetComponent<Renderer> ().material = yelflag;
			check23.GetComponent<Renderer> ().material = redflag;
			check24.GetComponent<Renderer> ().material = yelflag;
		}

		else if (Checkpoint.reachedcheckpoint24) {
			check21 = GameObject.Find ("Checkpoint21");
			check22 = GameObject.Find ("Checkpoint22");
			check23 = GameObject.Find ("Checkpoint23");
			check24 = GameObject.Find ("Checkpoint24");
			check21.GetComponent<Renderer> ().material = yelflag;
			check22.GetComponent<Renderer> ().material = yelflag;
			check23.GetComponent<Renderer> ().material = yelflag;
			check24.GetComponent<Renderer> ().material = redflag;
		}
	}
}
