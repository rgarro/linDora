using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public WheelCollider[] WColForward; //2
	public WheelCollider[] WColBack;  //3

	public float maxSteer = 30; //1
	public float maxAccel = 25; //2
	public float maxBrake = 50; //3

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {

		float accel = 0;
		float steer = 0;

		accel = Input.GetAxis("Vertical");  //4
		steer = Input.GetAxis("Horizontal");	 //4	

		CarMove(accel,steer); //5

	}

	private void CarMove(float accel,float steer){ //5

		foreach(WheelCollider col in WColForward){ //6
			col.steerAngle = steer*maxSteer; //6
		}

		if(accel == 0){ //7
			foreach(WheelCollider col in WColBack){  //7
				col.brakeTorque = maxBrake; //7
			}	

		}else{ //8

			foreach(WheelCollider col in WColBack){ //8
				col.brakeTorque = 0; //8
				col.motorTorque = accel*maxAccel; //8
			}	

		}



	}
}
