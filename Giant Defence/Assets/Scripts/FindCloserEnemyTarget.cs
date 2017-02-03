using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindCloserEnemyTarget : MonoBehaviour {
    public GameObject[] targets;
    private List<GameObject> selectedTargetsWithinRange=new List<GameObject>();
    private GameObject selectedTarget;
    //this one gets all the targets within range and put it into the list
    void pickTargets() {
        for (int i = 0; i < this.targets.Length; i++) {
            if (Vector3.Distance(targets[i].GetComponent<Transform>().position, this.transform.position) < this.GetData().GetMyStats().range) {
                this.selectedTargetsWithinRange.Add(targets[i]);
            }
        }
    }
    //this one picks the target who is more nearer to him and make that game object be the target
    void nearestTarget() {
        this.selectedTarget = this.selectedTargetsWithinRange[0];
        for (int i = 0; i < this.selectedTargetsWithinRange.Count; i++) {
            float odistance= Vector3.Distance(this.selectedTarget.GetComponent<Transform>().position, this.transform.position);
            float ndistance = Vector3.Distance(selectedTargetsWithinRange[i].GetComponent<Transform>().position, this.transform.position);
            if (ndistance < odistance)
            {
                this.selectedTarget = selectedTargetsWithinRange[i];
            }
        }
    }
    DataGetter GetData() {
        return this.gameObject.GetComponent<DataGetter>();
    }


}
