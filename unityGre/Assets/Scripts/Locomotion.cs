using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour

{
    Animator animator;
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Blend", Input.GetAxis("Vertical"));
    }
}
