using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindCloserEnemyTarget : MonoBehaviour {
    private GameObject target;
    private Object[] gEnemies;
    //first call the GetEnemy before executing finding the nearest
    //if this script is assign to player then find enemy vice versa
    //this one picks the target who is more nearer to him and make that game object be the target
    public void NearestEnemy() {
        if (this.gEnemies != null)
        {
            GameObject nearest = this.GetNearest(gEnemies);
            this.target = (nearest != null) ? nearest : null;
        }
    }
    public void NearestPlayer() {

    }
    GameObject GetNearest(Object[] enemies) {
        GameObject nearestEnemy = null;
        float dist = Mathf.Infinity;
        //problems here is that if i send a player object type it will get an error it should work find a way
        //work on Player Object when cannot use gameobject as reference since it will get an error
        foreach (Enemy e in enemies)
        {
            float d = Vector3.Distance(this.transform.position, e.transform.position);
            if (nearestEnemy == null || d < dist)
            {
                nearestEnemy = e.gameObject;
                dist = d;
            }
        }
        return nearestEnemy;
    }

    public void GetEnemies() {
        this.gEnemies = GameObject.FindObjectsOfType<Enemy>();
    }
    public void GetPlayer()
    {
        this.gEnemies = GameObject.FindObjectsOfType<Player>();
    }
    public GameObject GetTarget() {
        return this.target;
    }
    DataGetter GetData() {
        return this.gameObject.GetComponent<DataGetter>();
    }
}
