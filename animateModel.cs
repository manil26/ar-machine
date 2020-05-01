using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateModel : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator> ();
    }

    public void AnimateModel()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        Anim.Play("dismantle");
    }


}
