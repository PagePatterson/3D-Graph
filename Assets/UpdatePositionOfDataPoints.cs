using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField]
    private GameObject newposition;
    private float oneSecondTimer;

    void Update()
    {
        oneSecondTimer += Time.deltaTime;
        if (oneSecondTimer > 0.25f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, newposition.transform.localPosition.y, transform.localPosition.z);
            oneSecondTimer -= 0.25f;
        }
    }
}