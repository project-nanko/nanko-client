using UnityEngine;
using System.Collections;

public class EffectRef
{
	public ParticleSystem m_cParticle = null;
	public bool m_bUse = false;
}



public class EffectManager : MonoBehaviour 
{

	private EffectRef[] m_acEffectRef = new EffectRef[ 64 ];
	private int m_nLogOutputInterval = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (--m_nLogOutputInterval < 0) {
			m_nLogOutputInterval = 30;
			Debug.LogWarning ( "EffectManager Update" );
		}
	}
}
