using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(20, 40, 60)* Time.deltaTime);
    }
}
