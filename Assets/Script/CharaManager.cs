using UnityEngine;
using System.Collections;

public class CharaManager : MonoBehaviour {

	// win =====================================
	bool m_bOutputLogWin = true;
	// win =====================================
	// mac ----------------------------------
	bool m_bOutputLog = true;
	void OutputLog()
	{
		Debug.Log ( "CharaManager.OutputLog mac 2016.01.17 saisyu commit." );
	}
	// mac ----------------------------------

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( m_bOutputLogWin )
		{
			Debug.LogWarning( "CharaManager output WIN." );
		}
		if (m_bOutputLog) 
		{
			OutputLog ();
		}
	}
}
