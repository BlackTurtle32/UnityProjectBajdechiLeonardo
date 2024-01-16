using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorsFeatures : MonoBehaviour
{
    public GameObject leftDoor;

    public GameObject rightDoor;

    public AudioSource doorsSoundFx;

    void OnTriggerEnter(Collider other)
    {
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorsAnimationFeaturesOpenR");
        rightDoor.GetComponent<Animator>().Play("doubleDoorsAnimationFeaturesOpenL");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(3);
        doorsSoundFx.Play();
        leftDoor.GetComponent<Animator>().Play("doubleDoorsAnimationFeaturesCloseR");
        rightDoor.GetComponent<Animator>().Play("doubleDoorsAnimationFeaturesCloseL");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
