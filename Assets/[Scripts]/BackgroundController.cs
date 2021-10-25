/*
BackgroundController - GAME2014-F2021-MidTerm-[100753770]
Harrison Black, 100753770
Last modified - Oct. 23, 2021 
Scrolling background that moves back to other side of screen when it leaves the screen.

Revision History
Oct. 23, 2021 - changed touch movement direction to match screen orientation.
Oct. 23, 2021(2) - changed Variable names and added comments to make code more reader friendly  
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //Loop the background image back to inital position to reuse
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }
    //move background to the left
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }
    //if the image is off screen, call reset function
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
