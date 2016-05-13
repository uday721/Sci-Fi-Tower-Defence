using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour {

	public int planeSpeed=10;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.left * Time.deltaTime * planeSpeed);
        Destroy(gameObject, 8);
	}
}
