using UnityEngine;
using System.Collections;

public class AiDefenceControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
        this.DataGet().GetMyTarget().NearestEnemy();
        if (this.DataGet().GetMyTarget().GetTarget() != null) {
            this.DataGet().GetEnemyDirection().target = this.DataGet().GetMyTarget().GetTarget();
        }
	}
    DataGetter DataGet() {
        return this.gameObject.GetComponent<DataGetter>();
    }
}
