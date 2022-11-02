using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleStaff : MonoBehaviour
{
    public GameObject GunPlace;
    public AudioClip ItemClip;
    public AudioSource PlayerSource;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            GunPlace.SetActive(true);
            Destroy(gameObject);
            PlayerSource.pitch = 1f;
            PlayerSource.PlayOneShot(ItemClip);
        }
    }
}
