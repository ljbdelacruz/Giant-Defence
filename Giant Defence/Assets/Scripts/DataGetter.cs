using UnityEngine;
using System.Collections;

public class DataGetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
    public GameObject CurrentTarget() {
        return this.gameObject.GetComponent<FaceTarget>().target;
    } 
    public FaceTarget GetEnemyDirection()
    {
        return this.gameObject.GetComponent<FaceTarget>();
    }
    public Movement GetMovement()
    {
        return this.gameObject.GetComponent<Movement>();
    }
    public CollisionDetection GetCollisionDetector()
    {
        return this.gameObject.GetComponent<CollisionDetection>();
    }
    public MyAnimation GetAnimation() {
        return this.gameObject.GetComponent<MyAnimation>();
    }
    public Stats GetMyStats() {
        return this.gameObject.GetComponent<Stats>();
    }
}
