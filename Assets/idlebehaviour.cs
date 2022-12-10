using UnityEngine;

public class idlebehaviour : StateMachineBehaviour
{
    public float timer;
    public float maxTime;
    public float minTime;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = Random.Range(minTime, maxTime);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (timer <= 0)
        {
            animator.SetTrigger("attack");


        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
