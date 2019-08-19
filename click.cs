using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class click : MonoBehaviour
{
    public int sss = 0;
    public GameObject ems;
    public string keyword = "오함마";
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = ems.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void kill()
    {
        sss = sss + 1;
        animator.SetBool("평상", false);
        animator.SetBool(keyword, true);
        Invoke("idle", 2);

    }
    public void idle()
    {
        animator.SetBool(keyword, false);
        animator.SetBool("평상", true);
    }
}