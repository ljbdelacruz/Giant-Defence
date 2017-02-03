using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Rigidbody rb;
    private bool isMove = false;
    private Vector3 direction;
    // Use this for initialization
    void Start () {
	}
	// Update is called once per frame
	void Update () {
        if (isMove)
        {
            this.Move();
        }
        else {
            this.Stop();
        }
	}
    void Move() {
        this.transform.Translate(0, 0, this.GetData().GetMyStats().speed);
    }
    void Stop() {
        this.GetMyPosition().position = new Vector3(this.GetMyPosition().position.x, this.GetMyPosition().position.y, this.GetMyPosition().position.z);
    }
    public void PushBack() {
        float force = 3;
        // Calculate Angle Between the collision point and the player
        Vector3 dir = this.GetData().GetCollisionDetector().GetCollision().contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
        dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
        this.gameObject.GetComponent<Rigidbody>().AddForce(dir * force);
    }
    public void SetVelocity(Vector3 vel) {
        this.gameObject.GetComponent<Rigidbody>().velocity = vel;
    }
    public void SetIsMove(bool value) {
        this.isMove = value;
    }
    public bool GetIsMoving() {
        return this.isMove;
    }
    public void SetDirection(Vector3 dir) {
        this.direction = dir;
    }
    DataGetter GetData() {
        return this.gameObject.GetComponent<DataGetter>();
    }
    Transform GetMyPosition()
    {
        return this.gameObject.GetComponent<Transform>();
    }
}
