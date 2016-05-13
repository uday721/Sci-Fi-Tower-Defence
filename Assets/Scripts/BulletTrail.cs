using UnityEngine;
using System.Collections;

public class BulletTrail : MonoBehaviour {

    public int bulletMoveSpeed=10;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime*bulletMoveSpeed);
        Destroy(gameObject, 2);
	}
}
