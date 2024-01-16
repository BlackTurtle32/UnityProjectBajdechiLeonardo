using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleDoorsVFX : MonoBehaviour
{
    public GameObject leftDoor;

    public GameObject rightDoor;

    public AudioSource doorsSoundFx;

    void OnTriggerEnter(Collider other)
    {
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorsAnimationVFXOpenR");
        rightDoor.GetComponent<Animator>().Play("doubleDoorsAnimationVFXOpenL");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(3);
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorsAnimationVFXCloseR");
        rightDoor.GetComponent<Animator>().Play("doubleDoorsAnimationVFXCloseL");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
