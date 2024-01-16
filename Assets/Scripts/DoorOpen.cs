using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;

    public AudioSource doorSoundFx;

    void OnTriggerEnter(Collider other)
    {
        doorSoundFx.Play();
        door.GetComponent<Animator>().Play("DoorAnimation001");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(3);
        doorSoundFx.Play();
        door.GetComponent<Animator>().Play("DoorAnimationClose001");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
