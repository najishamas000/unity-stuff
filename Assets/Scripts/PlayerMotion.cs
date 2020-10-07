using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.FunBeansCorp.Scarie
{
	public class PlayerMotion : MonoBehaviour
	{
		public float speed;
		private Rigidbody rig;

    	void Start() {

    		rig = GetComponent<Rigidbody>();

    	}
    	void Update() {
    		//horizontal and vertical axes
    		float xMov = Input.GetAxis("Horizontal");
    		float yMov = Input.GetAxis("Vertical");

    		Vector2 direction_vector = new Vector2(xMov, yMov);
    		direction_vector.Normalize();
            rig.velocity = transform.TransformDirection(direction_vector) * speed * Time.deltaTime;
            Debug.Log(rig.velocity);


    	}
	}
}