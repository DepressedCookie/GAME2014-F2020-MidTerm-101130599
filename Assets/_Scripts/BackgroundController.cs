﻿// BackgroundController.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/20
// Description: This script is for scroolling background
// History: Changed from vertical to horzontal movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horzontalSpeed;
    public float horzontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horzontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horzontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horzontalBoundary)
        {
            _Reset();
        }
    }
}
