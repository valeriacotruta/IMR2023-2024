using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator mAnimator;
    public float attackDistance = 0.25f;
    public Transform target1;
    public Transform target2;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target1.position, target2.position);
        if (distance < attackDistance)
        {
            mAnimator.SetTrigger("TrAttack");
        } else
        {
            mAnimator.SetTrigger("TrClose");
        }
    }
}
