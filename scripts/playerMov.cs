using UnityEngine;
using System.Collections;
public class playerMov : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	private float x;
	private float y;
	private Vector3 rotateValue;

	private Vector3 moveDirection = Vector3.back;
	void Update() {
		
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

		y = Input.GetAxis("Mouse X");
		x = Input.GetAxis("Mouse Y");
		rotateValue = new Vector3(x, y * -1, 0);
		transform.eulerAngles = transform.eulerAngles - rotateValue;


	}
}