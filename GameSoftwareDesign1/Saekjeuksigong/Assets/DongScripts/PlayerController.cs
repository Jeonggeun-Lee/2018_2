using UnityEngine;
using System.Collections;

//<summary>
//Ball movement controlls and simple third-person-style camera
//</summary>
public class PlayerController: MonoBehaviour {

	public GameObject ViewCamera = null;
	public AudioClip JumpSound = null;
	public AudioClip HitSound = null;
	public AudioClip CoinSound = null;
    public AudioClip SpikeSound = null;

	private Rigidbody mRigidBody = null;
	private AudioSource mAudioSource = null;
	private bool mFloorTouched = false;

    private GameController control;
    public UIController ui;

    public int DeathCount;

    void Start () {
		mRigidBody = GetComponent<Rigidbody> ();
		mAudioSource = GetComponent<AudioSource> ();
        ui = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        control = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        
        DeathCount = 0;
	}

	void FixedUpdate () {
		if (mRigidBody != null) {
			if (Input.GetButton ("Horizontal")) {
				mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal")*10);
			}
			if (Input.GetButton ("Vertical")) {
				mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical")*10);
			}
			if (Input.GetButtonDown("Jump")) {
				if(mAudioSource != null && JumpSound != null){
					mAudioSource.PlayOneShot(JumpSound);
				}
				mRigidBody.AddForce(Vector3.up*200);
			}
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
        if (coll.gameObject.tag.Equals ("SpikeBall"))  //철퇴구슬에 부딪힐 경우 죽고 라이프 감소
        {                                
            gameObject.SetActive(false);           
            if (ui.Life != null)
            {
                ui.LoseLife(DeathCount);
                gameObject.transform.position = new Vector3(0, 1, 0);
                gameObject.SetActive(true);
            }
            DeathCount++;
        }
        if (DeathCount > 2)
        {
            control.GameOver();
            DeathCount = 0;   //게임오버 데스 초기화
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
