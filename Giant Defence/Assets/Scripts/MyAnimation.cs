using UnityEngine;
using System.Collections;

public class MyAnimation : MonoBehaviour {
    public Animator animator;
	// Use this for initialization
	void Start () {}
    // Update is called once per frame
    public void Animate(int state){
        switch (state) {
            case 1:
                this.IdleAnimation();
                break;
            case 2:
                this.WalkAnimation();
                break;
            case 3:
                this.AttackAnimation();
                break;
        }
    }
    void WalkAnimation()
    {
        this.animator.SetBool("isRunning", true);
        this.animator.SetBool("isAttacking", false);
    }
    void AttackAnimation()
    {
        this.animator.SetBool("isRunning", false);
        this.animator.SetBool("isAttacking", true);
    }
    void IdleAnimation() {
        this.animator.SetBool("isRunning", false);
        this.animator.SetBool("isAttacking", false);
    }
    public bool IsAnimationFinished(string animName, float normalizeTime) {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(animName) && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= normalizeTime)
        {
            return true;
        }
        return false;
    }

}
