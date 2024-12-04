using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    [SerializeField] private int _pointPerHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MainBall"))
        {
            GameManager.GameScore += _pointPerHit;
            Debug.Log("Шар столкнулся с " + this.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Шар перестал сталкиваться с " + this.name);
    }
}
