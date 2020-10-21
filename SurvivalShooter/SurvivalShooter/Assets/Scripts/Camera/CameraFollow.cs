using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraFollow : NetworkBehaviour
{
	/*public float speed = 6f;

	public Transform target;
	public float smoothing = 5f;

	private Vector3 offset;

    void Start()
	{
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		if(Input.GetButtonDown("Horizontal"))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	}*/
}
