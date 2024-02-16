using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDataZ : MonoBehaviour
{
    [SerializeField]
    private GameObject newposition;
    private float oneSecondTimer;
    // Update is called once per frame
    void Update()
    {
        oneSecondTimer += Time.deltaTime;
        if (oneSecondTimer > 0.25f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, newposition.transform.localPosition.z, transform.localPosition.z);
            oneSecondTimer -= 0.25f;
        }
    }
}
