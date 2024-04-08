using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationSwitch : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        InvokeRepeating("RandomAnimation", 0f, 10f);
    }

    void RandomAnimation()
    {
        int randomAnimationIndex = Random.Range(0, 3);
        animator.SetTrigger("ChangeAnimation" + randomAnimationIndex);
    }
}
