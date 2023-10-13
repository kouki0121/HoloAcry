using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public GameObject TargetObject;
    public Rigidbody TargetTransform;
    // Start is called before the first frame update
    void Start()
    {
        TargetTransform=TargetObject.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource();
        audioSource.clip = audioClip;
    }
    public void OnClick()
    {
        TargetTransform.velocity=new Vector3(6.0f,0.0f,0.0f);
        Invoke("object_stop",5.0f);
        audioSource.Play();
    }
    private void object_stop()
    {
        TargetTransform.velocity=new Vector3(0.0f,0.0f,0.0f);
    }
}