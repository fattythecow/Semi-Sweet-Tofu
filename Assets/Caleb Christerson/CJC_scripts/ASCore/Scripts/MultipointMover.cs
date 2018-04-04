using UnityEngine;

public class MultipointMover : MonoBehaviour {

    public Transform[] points;
    private int pointMarker = 0;
    private Transform currentPoint;
    private Vector3 lastPoint;
    private bool forward = true;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;
	[SerializeField]
	float waitTime = 0;
	[SerializeField]
	float maxWaitTimer = 1;
	float LastSpeed;
	//bool ReadyToGo = false;

    void Start ()
    {
        startTime = Time.time;
        lastPoint = transform.position;
		LastSpeed = speed;
    }

	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (shop.isopen == false) {

			if (forward) {
				currentPoint = points [pointMarker];
				journeyLength = Vector3.Distance (lastPoint, currentPoint.position);

				float distCovered = (Time.time - startTime) * speed;
				float fracJourney = distCovered / journeyLength;

				if (transform.position != currentPoint.transform.position) {
					transform.position = Vector3.Lerp (lastPoint, currentPoint.position, fracJourney);
				} else {
					// Get new time for next loop
					startTime = Time.time;
					lastPoint = transform.position;

					if (pointMarker != points.Length - 1)
						pointMarker++;
					else {
						waitTime += Time.deltaTime;
						if (waitTime >= maxWaitTimer) {
							forward = false;
							waitTime = 0;
						}
					}
                   
				}
			} else {
				// go in reverse
				currentPoint = points [pointMarker];
				journeyLength = Vector3.Distance (lastPoint, currentPoint.position);

				float distCovered = (Time.time - startTime) * speed;
				float fracJourney = distCovered / journeyLength;

				if (transform.position != currentPoint.transform.position) {
					transform.position = Vector3.Lerp (lastPoint, currentPoint.position, fracJourney);
				} else {
					// Get new time for next loop
					startTime = Time.time;
					lastPoint = transform.position;

					if (pointMarker != 0)
						pointMarker--;
					else {
						waitTime += Time.deltaTime;
						if (waitTime >= maxWaitTimer) {
							forward = true;
							waitTime = 0;
						}
					}
				}
			}
		}
	}
}
