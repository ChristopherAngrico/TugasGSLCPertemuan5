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
    public GameObject ChangeTheScene;
    private ChangeScene GetTheChangeSceneSCript;
    private void Awake() {
        GetTheChangeSceneSCript = ChangeTheScene.GetComponent<ChangeScene>();
    }
    public void Attack(){
        animator.SetBool("Attack", true);
        checkAnimation = true;
        StartCoroutine(nameof(SetAnimation));
        Invoke(nameof(ChangeAfterFinish),2f);
    }
    IEnumerator SetAnimation(){
        if(checkAnimation){
            yield return new WaitForSeconds(timeSet);
            animator.SetBool("Attack", false);
        }
        yield return null;
    }

    private void ChangeAfterFinish(){
        GetTheChangeSceneSCript.ChangeSceneScript("EndingScene");
    }
}
