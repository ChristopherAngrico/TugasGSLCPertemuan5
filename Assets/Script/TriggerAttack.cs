using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public Animator animator;
    private bool checkAnimation;
    int anim_count;
    [Range(0,1)]
    public float timeSet = 0.2f;
    public void Attack(){
        animator.SetBool("Attack", true);
        checkAnimation = true;
        StartCoroutine(nameof(SetAnimation));
    }
    IEnumerator SetAnimation(){
        if(checkAnimation){
            yield return new WaitForSeconds(timeSet);
            animator.SetBool("Attack", false);
        }
        yield return null;
    }
}
