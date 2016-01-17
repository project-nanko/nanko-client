using UnityEngine;
using System.Collections;

public class CharaBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vPos = this.transform.position;
		vPos.y += 0.1f;
		vPos.x += 0.1f;
		if (vPos.y > 10.0f) {
			vPos.y = 0.0f;
			vPos.x = 0.0f;
		}
		this.transform.position = vPos;
	}
}
