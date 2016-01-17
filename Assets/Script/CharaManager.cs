using UnityEngine;
using System.Collections;

public class CharaManager : MonoBehaviour {

	// mac ----------------------------------
	bool m_bOutputLog = true;
	void OutputLog()
	{
		Debug.Log ( "CharaManager.OutputLog" );
	}

	// mac ----------------------------------

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (m_bOutputLog) {
			OutputLog ();
		}
	}
}
