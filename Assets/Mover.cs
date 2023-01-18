using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the jungle!");
        Debug.Log("Move player around with WASD or arrow keys");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zJump = Input.GetAxis("Jump");
        transform.Translate(xValue,zJump,zValue);
    }
}
