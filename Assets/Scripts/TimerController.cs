using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerController : MonoBehaviour {

    public Transform LoadingBar;
    public Animator anim;
    public Animator anim2;
    [SerializeField] private float currentAmount;
    [SerializeField] public float speed;
    private float maxAmount;
    private bool anim2Running = false;

    void Start ()
    {
       
        anim2 = GameObject.Find("GradientRotator").GetComponent<Animator>();
    }

	void Update () {
	if (!anim2Running)
        {
            anim2.SetBool("Go", true);
            anim2Running = true;
        }

        if(currentAmount > 0)
        {
            currentAmount -= speed = Time.deltaTime;
        }
        ClockFill();

        if(currentAmount <= 0)
        {
            anim.SetBool("loser", true);
        }
    }

    public void ClockFill()
    {
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 30;
    }
}
