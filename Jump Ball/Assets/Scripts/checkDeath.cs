using UnityEngine;
using System.Collections;

public class checkDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider _col) {
         if(_col.gameObject.tag == "Block" ){
             GameManager.Instance.GameOver();
             //Health health = _col.GetComponent<Collider>().GetComponentInParent<Health>();
         }
         if(_col.gameObject.tag == "Pass" ){
             Destroy(_col);
             GameManager.Instance.TriggerScore();
             print("TriggerScore");
         }
    }
}
