using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    private GameObject goCollided;
    private bool isCollided=false;
    private Collision col1;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
    void OnCollisionEnter(Collision col) {
        this.goCollided = col.gameObject;
        this.col1 = col;
        this.isCollided = true;
    }
    void OnCollisionExit() {
        this.isCollided = false;
    }
    public bool GetIsCollided() {
        return this.isCollided;
    }
    public GameObject GetGOCollided() {
        return this.goCollided;
    }
    public Collision GetCollision() {
        return this.col1;
    }
    public string GetGameObjectNameCollided() {
        return this.goCollided.name;
    }
}
