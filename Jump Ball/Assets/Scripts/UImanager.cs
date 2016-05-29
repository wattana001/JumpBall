using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {


    public Text txtScore;
    public GameObject ObjGameOver;
    public GameObject ObjPause;
    
    public GameObject btnPause;
    public GameObject btnResume;
    
    private static UImanager instance = null;
    public static UImanager Instance
    {
        get{return instance;}
    }
	// Use this for initialization
	void Start () {
	   ObjGameOver.SetActive(false);
	}
	
    public void ToggleBtn(){
        if(btnPause.active){
            btnResume.SetActive(true);
            btnPause.SetActive(false);
            Time.timeScale = 0F;
            print("Pause");
            
        }else{
            btnResume.SetActive(false);
            btnPause.SetActive(true);
            Time.timeScale = 1F;
            print("Resume");
        }
    }
    public void RestartBtn(){
        GameManager.Instance.Restart();
    }
    public void Quit(){
        Application.Quit();
    }
    public void ShowGameover(){
        if(ObjGameOver != null){
            ObjGameOver.SetActive(true);
        }else {
            print("Gameover = null");
        }
        
    }
    
    public void ShowGameOver(){
         ObjGameOver.SetActive(true);
    }
    public void HideGameOver(){
         ObjGameOver.SetActive(false);
    }
    public void ShowPause(){
         ObjGameOver.SetActive(true);
    }
    public void HidePause(){
         ObjPause.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
	   txtScore.text = GameManager.Instance.score.ToString();
	}
}
