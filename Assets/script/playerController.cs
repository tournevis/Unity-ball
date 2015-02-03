using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	// Use this for initialization
	public GUIText countTText; 
	public float speed;
	private int count;
	void start(){
		count = 0;
		setCount();
	}
	void FixedUpdate(){
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 movement =new Vector3(horizontal, 0.0f , vertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);

	}
	void OnTriggerEnter(Collider other ){

		if (other.gameObject.tag == "PickItem") {
			other.gameObject.SetActive(false);	
			count ++;
			setCount();
		}
	}
	void setCount(){
		countTText.text = "Score : " + count.ToString();
	}
}
