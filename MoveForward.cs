﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoword : MonoBehaviour
public float speed = 40;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.foword * Time.deltaTime * speed );
    }
}
