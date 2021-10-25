/*
EnemyController - GAME2014-F2021-MidTerm-[100753770]
Harrison Black, 100753770
Last modified - Oct. 23, 2021 
Functionality for emeny space crafts: movement and boundies of movement

Revision History
Oct. 23, 2021 - change movement direction to match screen orientation, set bounds as fixed space to match screen.
Oct. 23, 2021(2) - changed Variable names and added comments to make code more reader friendly  
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    float horizontalBoundary = 3;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    //movement
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    // makes sure the enemy craft is within the screen. if its going to leave, flip direction.
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
