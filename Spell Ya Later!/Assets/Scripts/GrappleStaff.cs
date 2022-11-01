using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleStaff : MonoBehaviour
{
    public GameObject GunPlace;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            GunPlace.SetActive(true);
            Destroy(gameObject);
        }
    }
}
