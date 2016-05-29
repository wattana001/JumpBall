using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

    public int ballHeight = 380;
    public float speedMove = 3F;
    
    public float frequencyBlock = 5F; 
    
    public int tapBall = 2;
    private int tempTapBall;
    
    public double blockScore = 1;
    
    public List<GameObject> lstBlock = new List<GameObject>();
    public GameObject startPoint;
    public GameObject uiGameover;
    
    
    public double score = 0;
    public int blockIndex = 0;
    private bool waitting = false;
    
	private static GameManager instance = null;
    public static GameManager Instance
    {
        get{return instance;}
    }
    void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    void Start(){
        tempTapBall = tapBall;
    }
    public void randomIndex(){
        if(lstBlock != null){
            blockIndex = Random.Range(0, lstBlock.Count);
        }
    }
    
    IEnumerator Delay() {
        randomIndex();
        Instantiate( lstBlock[blockIndex], startPoint.transform.position, Quaternion.identity);
        waitting = true;
        yield return new WaitForSeconds(frequencyBlock);
        waitting = false;
    }
    public void GameOver(){
         uiGameover.SetActive(true);
         Time.timeScale = 0.0F;
         print("Game over");
    }
    public void Restart(){
        Application.LoadLevel( 0 );
        Time.timeScale = 1F;
    }
    public void TriggerScore(){
        score += blockScore;
        tapBall = tempTapBall;
    }
    void Update() {
        if(!waitting)
            StartCoroutine(Delay());
    }
}
