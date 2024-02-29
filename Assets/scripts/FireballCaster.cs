﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Fireball fireballPrefab;
    public Transform fireballSourseTransform;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSourseTransform.position, fireballSourseTransform.rotation);
        }
    }


}
