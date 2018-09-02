using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRoot : MonoBehaviour {

    private static ViewRoot m_instace;

    public static ViewRoot Instace
    {
        get
        {
            return m_instace;
        }
    }

    private void Awake()
    {
        m_instace = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
