using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
    public int hp, damage, attackSpeed, perform = 0;
    public float range, speed;
    public bool isDead = false;
	// Use this for initialization
	void Start () {}
    void Update()
    {
        if (this.hp <= 0) {
            this.isDead = true;
        }
    }
    public void DeductHp(int value){
        this.hp -= value;
    }
    public void AddHp(int value) {
        this.hp += value;
    }
    public void SetIsDead(bool value) {
        this.isDead = value;
    }
    public int GetDamage()
    {
        return this.damage;
    }
    public float GetSpeed() {
        return this.speed;
    }
    public int GetAttackSpeed() {
        return this.attackSpeed;
    }
    public bool GetIsDead() {
        return this.isDead;
    }

}

