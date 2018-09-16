using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agen : MonoBehaviour {
	public Text touchXtext;
	public Text touchYtext;

	private float durasi = 0.1f;
	private float waktuTersisa = 0;
	private GameObject bola;

	void Awake(){
		touchXtext.text="xx";
		touchYtext.text="yy";
		bola = Resources.Load<GameObject> ("Prefabs/bola");

	}
	void Update(){
		if (Input.touchCount == 1) {
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				
				Touch touch = Input.GetTouch (0);
				Vector3 touchWorld = new Vector3 (touch.position.x, touch.position.y, 0);

				touchXtext.text = "Touch Pos X = " + touchWorld.x;
				touchYtext.text = "Touch Pos Y = " + touchWorld.y;

				Vector2 arahJari = Camera.main.ScreenToWorldPoint (touchWorld) - transform.position;
				float sudut = Mathf.Atan2 (arahJari.y, arahJari.x) * Mathf.Rad2Deg;

				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, sudut));
			} else if(Input.GetTouch (0).phase == TouchPhase.Began){
				waktuTersisa = 0;
			}
		}

		if (waktuTersisa < durasi) {
			waktuTersisa += Time.deltaTime;
			if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended){ 
				Instantiate (bola, transform.position, transform.rotation);
			}
		} 
	}
}