using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private float speedForward = 3F;
    public float positionDestroy = -20;
    void Start(){
        speedForward = GameManager.Instance.speedMove;
    }
    void Update() {

        transform.Translate( -(Time.deltaTime * speedForward), 0, 0);
        
        if(transform.position.x <= positionDestroy){
            Destroy( gameObject );
        }
    }
}
