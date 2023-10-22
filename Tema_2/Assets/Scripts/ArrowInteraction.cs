using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowInteraction : MonoBehaviour
{
    public Scoring scoring;
    public float distance = 1.0f;
    public Transform arrow;
    private Vector3 arrowInitialPosition;
    public Transform board;
    private float currentDistance;
    public Rigidbody rb;
    public bool isAlreadyProcessed = false;

    // Start is called before the first frame update
    void Start()
    {
        arrowInitialPosition = arrow.position;
        Debug.Log("Initial position"+arrowInitialPosition);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentDistance);
        currentDistance = Vector3.Distance(arrow.position, board.position);
        if (currentDistance <= distance && this.isAlreadyProcessed == false)
        {
            scoring.AddToScore(1);
            currentDistance = 10f;
            rb.isKinematic = true;
            this.isAlreadyProcessed = true;
        }
        else
        {

         }
    }
}