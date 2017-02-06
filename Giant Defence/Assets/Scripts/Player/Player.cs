using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    // Use this for initialization
    public bool isFighting;
	void Start () {
        if (this.isFighting)
        {
            this.gameObject.GetComponent<DataGetter>().GetMyTarget().GetEnemies();
        }
	}
	
}
