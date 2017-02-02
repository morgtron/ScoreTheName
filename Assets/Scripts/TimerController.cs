using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerController : MonoBehaviour {
        
    public Animator anim;
   
    void Start ()
    {
       anim = GameObject.Find("Canvas").GetComponent<Animator>();
    }
    	
    public void TimerUp()
    {
        anim.SetBool("loser", true);
    }    
}
