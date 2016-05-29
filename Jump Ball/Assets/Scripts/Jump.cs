using UnityEngine;
using System.Collections;
 
 public class Jump : MonoBehaviour {
     
     // Use this for initialization
     void Start () {
     
     }
     
     // Update is called once per frame
     void Update () {
         if (Input.GetKeyDown ( KeyCode.Space ) && GameManager.Instance.tapBall > 0){
             this.GetComponent<Rigidbody>().AddForce(new Vector3(0, GameManager.Instance.ballHeight, 0));
             GameManager.Instance.tapBall--;
         }
         
         //check ball height
         if(transform.position.y > 10 || transform.position.y < -8 ){
             GameManager.Instance.GameOver();
         }
     }
 }
 