using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Q))
			transform.position = new Vector3 (-5, 0, 0);
	
		if (Input.GetKey (KeyCode.W))
		transform.position = new Vector3 (0, 0,0);

		if (Input.GetKey (KeyCode.E))
			transform.position = new Vector3 (5, 0 ,0);

}
}
