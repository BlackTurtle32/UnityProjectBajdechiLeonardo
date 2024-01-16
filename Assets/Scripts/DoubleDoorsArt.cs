using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorsArt : MonoBehaviour
{
    public GameObject leftDoor;

    public GameObject rightDoor;

    public AudioSource doorsSoundFx;

    void OnTriggerEnter(Collider other)
    {
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorAnimationOpen");
        rightDoor.GetComponent<Animator>().Play("doubleDoorAnimationOpen2");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(3);
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorAnimationClose");
        rightDoor.GetComponent<Animator>().Play("doubleDoorAnimationClose2");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
