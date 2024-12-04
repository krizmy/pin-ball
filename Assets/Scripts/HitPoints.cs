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
            Debug.Log("��� ���������� � " + this.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("��� �������� ������������ � " + this.name);
    }
}
