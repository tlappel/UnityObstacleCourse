using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score =0;
   private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("collision!");
        this.score++;
        Debug.Log("Player has hit "+ score + " Things!");
        //GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
