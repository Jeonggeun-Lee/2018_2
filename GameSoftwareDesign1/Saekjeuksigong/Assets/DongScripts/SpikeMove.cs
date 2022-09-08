using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{

    private Rigidbody mRigidBody = null;

    void Start()
    {
        mRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (mRigidBody != null)
        {
            if (Input.GetButton("Horizontal"))
            {
                mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * 20);
            }
            if (Input.GetButton("Vertical"))
            {
                mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical") * 20);
            }
            //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
            if (Input.acceleration.x != 0)
            {
                mRigidBody.AddTorque(Vector3.back * Input.acceleration.x * 20);
            }
            if (Input.acceleration.y != 0)
            {
                mRigidBody.AddTorque(Vector3.right * Input.acceleration.y * 20);
            }

            /*
			if (Input.GetButtonDown("Jump")) {
				if(mAudioSource != null && JumpSound != null){
					mAudioSource.PlayOneShot(JumpSound);
				}
				mRigidBody.AddForce(Vector3.up*200);
			}*/
        }
    }
}
