using UnityEngine;
using System.Collections;

public class AiControl : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
        if (this.GetData().GetEnemyDirection().GetIsSeen() && this.GetData().GetCollisionDetector().GetIsCollided() == false)
        {
            this.GetData().GetMovement().SetDirection(this.GetData().GetEnemyDirection().GetDirection());
            this.GetData().GetMovement().SetIsMove(true);
            this.GetData().GetAnimation().Animate(2);
        }
        else {
            if (this.GetData().GetCollisionDetector().GetIsCollided() == true && this.GetData().CurrentTarget().name == this.GetData().GetCollisionDetector().GetGOCollided().name)
            {
                this.GetData().GetAnimation().Animate(3);
                if (this.GetData().GetAnimation().IsAnimationFinished("Attacking", 1f)) {
                    this.GetData().GetAnimation().Animate(1);
                    Debug.Log(this.GetData().CurrentTarget().name);
                    if (this.GetData().GetMyStats().perform == 0)
                    {
                        this.GetData().CurrentTarget().GetComponent<Stats>().DeductHp(this.GetData().GetMyStats().damage);
                    }
                    this.GetData().GetMyStats().perform++;
                    if (this.GetData().GetMyStats().perform >= this.GetData().GetMyStats().attackSpeed)
                    {
                        this.SetPerformToZero();
                    }
                }
            }
            else
            {
                //this is for attack stats purpose
                this.SetPerformToZero();
                this.GetData().GetMovement().SetVelocity(new Vector3(0, 0, 0));
                //animation purpose
                this.GetData().GetAnimation().Animate(1);
            }
            this.GetData().GetMovement().SetIsMove(false);
        }
	}
    DataGetter GetData() {
        return this.gameObject.GetComponent<DataGetter>();
    }
    void SetPerformToZero() {
        this.GetData().GetMyStats().perform = 0;
    }

}
