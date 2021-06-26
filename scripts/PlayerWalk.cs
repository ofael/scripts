using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    //componente rigidbody2d
    Rigidbody2D rig;
    //velocidade do player
    float speed;
    //vetor3
    Vector3 playerWalk;
    // Start is called before the first frame update
    void Start()
    {
        //atribuindo a variavel rig o componente rigidbody
        rig = GetComponent<Rigidbody2D>();
        playerWalk = Vector3.zero;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //atribuindo a variavel playerWalk um input
        playerWalk.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rig.velocity = playerWalk;
    }
}
