using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject point;
    [SerializeField] private GameObject ParticleSystem;

    void Start(){
        point = GameObject.Find("CORE");
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ammo"){
            point.GetComponent<POINT1>().Add(1);
            Destroy(gameObject);

            Instantiate(ParticleSystem, this.transform.position, Quaternion.identity);
        }
    }
}
