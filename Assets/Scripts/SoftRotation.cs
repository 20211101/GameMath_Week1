using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftRotation : MonoBehaviour
{
    float angularSpeed = 20f;
    void Update()
    {
        float angle = Utils.CalcAngleFromCursor(transform.position);
        angle -= 90;
        // --------- Code 1 ----------
        //Vector3 purposVec = new Vector3(0,0,angle);

        //transform.rotation = Quaternion.Lerp(transform.rotation
        //                                , Quaternion.Euler(purposVec), 0.01f);

        // --------- Code 2 ----------
        //Quaternion targetRot = Quaternion.AngleAxis(angle, Vector3.forward);

        //transform.rotation = Quaternion.RotateTowards(
        //    transform.rotation,
        //    targetRot,
        //    360 * Time.deltaTime);
    }
}
