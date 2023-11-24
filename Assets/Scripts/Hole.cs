using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Ball b = collision.gameObject.GetComponent<Ball>();

        if (b != null)
        {
            GameManager.Instance.PlayerScore += b.Point;
            Destroy(b.gameObject);
        }
    }
}
