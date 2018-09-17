using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BolaSampah)),CanEditMultipleObjects]
public class EditorObjekSampah : Editor {

	private BolaSampah bolaSampah;
	private GameObject objekBolaSampah;

	private void OnSceneGUI(){
		objekBolaSampah = Resources.Load<GameObject> ("Prefabs/bolasampah");
		bolaSampah = (BolaSampah)target;

		Vector2 posKiri = new Vector2 (-0.7f + bolaSampah.transform.position.x, 0 + bolaSampah.transform.position.y);
		Vector2 posKanan = new Vector2 (0.7f + bolaSampah.transform.position.x, 0 + bolaSampah.transform.position.y);
		Vector2 posKiriBawah = new Vector2 (-0.35f + bolaSampah.transform.position.x, -0.6f + bolaSampah.transform.position.y);
		Vector2 posKananBawah = new Vector2 (0.35f + bolaSampah.transform.position.x, -0.6f + bolaSampah.transform.position.y);


		GameObject instBolaSampah;
		Handles.color = Color.red;
		if (Handles.Button (bolaSampah.transform.position, Quaternion.identity, 0.2f, 0.2f, Handles.CircleHandleCap)) {
			Undo.DestroyObjectImmediate (bolaSampah.gameObject);
		}

		Handles.color = Color.cyan;
		if (!Physics2D.OverlapCircle(posKiri,0.3f,1)) {
			if (Handles.Button (posKiri, Quaternion.identity, 0.3f, 0.3f, Handles.CircleHandleCap)) {
				instBolaSampah = Instantiate (objekBolaSampah, posKiri, bolaSampah.transform.rotation);
				Undo.RegisterCreatedObjectUndo (instBolaSampah.gameObject, "instBolaSampah");
			}
		}
		if (!Physics2D.OverlapCircle(posKanan,0.3f,1)) {
			if (Handles.Button (posKanan, Quaternion.identity, 0.3f, 0.3f, Handles.CircleHandleCap)) {
				instBolaSampah = Instantiate (objekBolaSampah, posKanan, bolaSampah.transform.rotation);
				Undo.RegisterCreatedObjectUndo (instBolaSampah.gameObject, "instBolaSampah");
			}
		}
		if (!Physics2D.OverlapCircle(posKiriBawah,0.3f,1)) {
			if (Handles.Button (posKiriBawah, Quaternion.identity, 0.3f, 0.3f, Handles.CircleHandleCap)) {
				instBolaSampah = Instantiate (objekBolaSampah, posKiriBawah, bolaSampah.transform.rotation);
				Undo.RegisterCreatedObjectUndo (instBolaSampah.gameObject, "instBolaSampah");
			}
		}
		if (!Physics2D.OverlapCircle(posKananBawah,0.3f,1)) {
			if (Handles.Button (posKananBawah, Quaternion.identity, 0.3f, 0.3f, Handles.CircleHandleCap)) {
				instBolaSampah = Instantiate (objekBolaSampah, posKananBawah, bolaSampah.transform.rotation);
				Undo.RegisterCreatedObjectUndo (instBolaSampah.gameObject, "instBolaSampah");
			}
		}
	}
}