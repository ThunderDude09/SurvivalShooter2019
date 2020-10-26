using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class CameraFollow : NetworkBehaviour
{
	PlayerMovement localPlayer;
	//public float speed = 6f;
	Transform target;
	public float smoothing = 5f;
	bool isPlayer;

	private Vector3 offset;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		if (localPlayer == null)
        {
			foreach (PlayerMovement pm in FindObjectsOfType<PlayerMovement>())
			{
				isPlayer = true;
				localPlayer = pm;
			}
		}
		
		//transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
