using UnityEngine;
using System.Collections;

public class RotationCube : MonoBehaviour
{

    float velocity = 2;

	private float ramdonTime;
	private Vector3 rotateDir;
	// Use this for initialization
	void Start ()
	{
		float x, y, z;
		x = Random.Range (5, 10);
		y = Random.Range (5, 10);
		z = Random.Range (5, 10);
		rotateDir = new Vector3(x,y,z);

		ramdonTime = Random.Range (2, 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
		ramdonTime -= Time.deltaTime * 1;

		transform.Rotate(rotateDir * Time.deltaTime* velocity);


		if (ramdonTime <= 0) {
			Start ();
		}
	}//fecha update



}
//fecha a classe
