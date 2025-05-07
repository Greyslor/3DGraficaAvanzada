using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    public Transform pointToView;
    public float rangeHand;
    
    public Object libro;
    public float distancia;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            animator.SetTrigger("Attack");
        }


    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(1f, 1f);
        animator.SetLookAtPosition(pointToView.position);

        animator.SetLookAtPosition(target.position);
        //animator.SetLookAtPosition();
        //animator.

        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rangeHand);
        
        animator.SetIKPosition(AvatarIKGoal.RightHand, pointToView.position);


    }
}
