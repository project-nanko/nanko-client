using UnityEngine;
using System.Collections;

public class CharaManager : MonoBehaviour {

	// win =====================================
	bool m_bOutputLogWin = true;
	// win =====================================


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( m_bOutputLogWin )
		{
			Debug.LogWarning( "CharaManager output WIN." );
		}
	}
}
