using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraFollow : NetworkBehaviour
{
	public float speed = 6f;

	private Vector3 movement;

	Transform target;
	public float smoothing = 5f;

	private Vector3 offset;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		if (!isLocalPlayer)
			return;

		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		//Vector3 targetCamPos = new Vector3(target.position.x, target.position.y, transform.position.z);
		//Vector3 targetCamPos = target.position + offset;
		//transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

	}
}
