using UnityEngine;
using System.Collections;

public class AiDefenceControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}

    DataGetter DataGet() {
        return this.gameObject.GetComponent<DataGetter>();
    }
}
