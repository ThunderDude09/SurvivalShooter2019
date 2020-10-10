using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 6f;

	public float speed2 = 114f;

	private Vector3 movement;
	private Animator anim;
	private Rigidbody playerRigidbody;
	private int floorMask;
	private float camRayLength = 100f;

	[SerializeField]
	int playerIndex = 1;

	void Awake()
	{

		floorMask = LayerMask.GetMask("Floor");
		anim = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		

		Move(h, v);
		Turning();
		Animating(h, v);
	}

	void Move(float h, float v)
	{
		transform.Translate(0, 0,Input.GetAxis("Vertical" + playerIndex) * speed * Time.deltaTime);
		//movement.Set(h, 0f, v);
		//movement = movement.normalized * speed * Time.deltaTime;

		//playerRigidbody.MovePosition(transform.position + movement);

	}

	void Turning()
	{
		transform.Rotate(0, Input.GetAxis("Horizontal" + playerIndex) * speed2 * Time.deltaTime, 0);
		//Ray leftRight = 
		//Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		/*RaycastHit floorHit;

		if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask)) {
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;

			Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
			playerRigidbody.MoveRotation(newRotation);
		}*/
	}

	void Animating(float h, float v)
	{
		bool walking = h != 0f || v != 0f;

		anim.SetBool("IsWalking", walking);
	}
}
