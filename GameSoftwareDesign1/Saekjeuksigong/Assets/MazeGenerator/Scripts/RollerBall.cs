﻿using UnityEngine;
using System.Collections;

//<summary>
//Ball movement controlls and simple third-person-style camera
//</summary>
public class RollerBall : MonoBehaviour {

	public GameObject ViewCamera = null;
	public AudioClip JumpSound = null;
	public AudioClip HitSound = null;
	public AudioClip CoinSound = null;
    public AudioClip ItemSound;

	private Rigidbody mRigidBody = null;
	private AudioSource mAudioSource = null;
	private bool mFloorTouched = false;

    public bool upsideDown = false;
    public bool leftToRight = false;

	public const float TORQUEMULTIPLYER = 30;

	void Start () {
		mRigidBody = GetComponent<Rigidbody> ();
		mAudioSource = GetComponent<AudioSource> ();
	}

	void FixedUpdate () {
		if (mRigidBody != null) {
            if(upsideDown==false && leftToRight == false)
            {
                if (Input.GetButton("Horizontal"))
                {
					mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * TORQUEMULTIPLYER);
                }
                if (Input.GetButton("Vertical"))
                {
					mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical") * TORQUEMULTIPLYER);
                }
                //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
                if (Input.acceleration.x != 0)
                {
					mRigidBody.AddTorque(Vector3.back * Input.acceleration.x * TORQUEMULTIPLYER);
                }
                if (Input.acceleration.y != 0)
                {
					mRigidBody.AddTorque(Vector3.right * Input.acceleration.y * TORQUEMULTIPLYER);
                }
            }

            if (upsideDown == false && leftToRight == true)
            {
                if (Input.GetButton("Horizontal"))
                {
					mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * (-TORQUEMULTIPLYER));
                }
                if (Input.GetButton("Vertical"))
                {
					mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical") * TORQUEMULTIPLYER);
                }
                //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
                if (Input.acceleration.x != 0)
                {
					mRigidBody.AddTorque(Vector3.back * Input.acceleration.x * (-TORQUEMULTIPLYER));
                }
                if (Input.acceleration.y != 0)
                {
					mRigidBody.AddTorque(Vector3.right * Input.acceleration.y * TORQUEMULTIPLYER);
                }
            }

            if (upsideDown == true && leftToRight == false)
            {
                if (Input.GetButton("Horizontal"))
                {
					mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * TORQUEMULTIPLYER);
                }
                if (Input.GetButton("Vertical"))
                {
					mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical") * (-TORQUEMULTIPLYER));
                }
                //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
                if (Input.acceleration.x != 0)
                {
					mRigidBody.AddTorque(Vector3.back * Input.acceleration.x * TORQUEMULTIPLYER);
                }
                if (Input.acceleration.y != 0)
                {
					mRigidBody.AddTorque(Vector3.right * Input.acceleration.y * (-TORQUEMULTIPLYER));
                }
            }
            if (upsideDown == true && leftToRight == true)
            {
                if (Input.GetButton("Horizontal"))
                {
					mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal") * (-TORQUEMULTIPLYER));
                }
                if (Input.GetButton("Vertical"))
                {
					mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical") * (-TORQUEMULTIPLYER));
                }
                //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
                if (Input.acceleration.x != 0)
                {
					mRigidBody.AddTorque(Vector3.back * Input.acceleration.x * (-TORQUEMULTIPLYER));
                }
                if (Input.acceleration.y != 0)
                {
					mRigidBody.AddTorque(Vector3.right * Input.acceleration.y * (-TORQUEMULTIPLYER));
                }
            }

            /*
			if (Input.GetButtonDown("Jump")) {
				if(mAudioSource != null && JumpSound != null){
					mAudioSource.PlayOneShot(JumpSound);
				}
				mRigidBody.AddForce(Vector3.up*200);
			}*/
        }
		if (ViewCamera != null) {
			Vector3 direction = (Vector3.up*2+Vector3.back)*2;
			RaycastHit hit;
			Debug.DrawLine(transform.position,transform.position+direction,Color.red);
			if(Physics.Linecast(transform.position,transform.position+direction,out hit)){
				ViewCamera.transform.position = hit.point;
			}else{
				ViewCamera.transform.position = transform.position+direction;
			}
			ViewCamera.transform.LookAt(transform.position);
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = true;
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.y > .5f) {
				mAudioSource.PlayOneShot (HitSound, coll.relativeVelocity.magnitude);
			}
		} else {
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.magnitude > 2f) {
				mAudioSource.PlayOneShot (HitSound, coll.relativeVelocity.magnitude);
			}
		}
        if (coll.gameObject.CompareTag("Item"))
        {
            mAudioSource.PlayOneShot(ItemSound);
        }
	}

	void OnCollisionExit(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("Coin")) {
			if(mAudioSource != null && CoinSound != null){
				mAudioSource.PlayOneShot(CoinSound);
			}
			Destroy(other.gameObject);
		}
        
	}
   
}