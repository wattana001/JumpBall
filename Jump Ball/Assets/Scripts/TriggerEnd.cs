using UnityEngine;
using System.Collections;

public class TriggerEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider _col) {
        if (_col.gameObject.tag == "Block")
        {
            Destroy(_col.gameObject);
        }
        
    }
}
