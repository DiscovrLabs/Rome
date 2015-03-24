using UnityEngine;
using System.Collections;

public class map_select : MonoBehaviour {

	public float answer;
	public string level;
	float guess=0;

	Ray ray;
	RaycastHit hit;

	void Start () {
	
	}

	void Update () {


		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));

		if (Physics.Raycast (ray, out hit)) {

			
			Debug.Log (hit.collider.name);

			if (Input.GetMouseButtonDown (0)) 
			{

				if (hit.collider.name == ("Mission_1")) {
					guess=1;
				}
				
				if (hit.collider.name == ("Explore_1")) {
					guess=2;
				}				
				
				if (hit.collider.name == ("Abort_1")) {
					guess=3;
				}
				
				if (hit.collider.name == ("West_1")) {
					guess=4;
				}
				
				if (hit.collider.name == ("EastN_1")) {
					guess=5;
				}
				
				if (hit.collider.name == ("EastS_1")) {
					guess=6;
				}
				
				if (hit.collider.name == ("WestS_1")) {
					guess=7;
				}
				
				if (hit.collider.name == ("WestN_1")) {
					guess=8;
				}
				check ();
			}
		}
	
	}

	void check()
	{
		if (guess == answer)
		{
			Debug.Log ("CORRECT");
			GameObject.Find("correct_audio").SendMessage("playSound");
			Application.LoadLevel(level);
		}
	}
}
