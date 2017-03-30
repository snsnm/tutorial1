using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ProjectileLauncher : MonoBehaviour, IInputClickHandler {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		InputManager.Instance.PushModalInputHandler(this.gameObject);
	}

	public void OnInputClicked (InputEventData eventData){

		GameObject projectile = Instantiate (prefab) as GameObject;
		projectile.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 0.85f;
		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = Camera.main.transform.forward * 10;
	}
}
