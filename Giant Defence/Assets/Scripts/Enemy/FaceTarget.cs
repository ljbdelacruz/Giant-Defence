using UnityEngine;
using System.Collections;

public class FaceTarget : MonoBehaviour {
    public GameObject target;
    private bool isSeen = false;
    private Vector3 direction;
	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
        this.FindTarget();
	}
    void FindTarget() {
        if (this.target != null && Vector3.Distance(target.GetComponent<Transform>().position, this.transform.position) < this.GetData().GetMyStats().range)
        {
            this.isSeen = true;
            direction = target.GetComponent<Transform>().position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        }
        else {
            this.isSeen = false;
        }
    }
    public bool GetIsSeen() {
        return this.isSeen;
    }
    public Vector3 GetDirection() {
        return this.direction;
    }
    DataGetter GetData() {
        return this.gameObject.GetComponent<DataGetter>();
    }
}
