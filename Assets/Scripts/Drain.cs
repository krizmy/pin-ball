using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drain : MonoBehaviour
{
    // Collider - ��� ������ �������� �������� ������� 
    // isTrigger - ����������� ���� (������� ������ ���������) ����� ������� �������� ���������� � � ������ ������������� ��� ������� ����� ����� ��� ������ ����
    // ���� - ������� ������ �������� �� �����
    private void OnTriggerEnter(Collider other)// ��� ������� ����� ��� ����, ����� ����������� ��� ������� � �����������, �������
                                               //������ � ������� ���� (� ������� �� ������� ��������� ������ � ���� ��������� Collider � �������� ������� isTrigger)
    {
        if (other.gameObject.CompareTag("MainBall"))
        {
            GameManager.BallCount -= 1;
            Debug.Log("��� ����� � �����!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainBall"))
        {            
            Debug.Log("��� ����� �� ������!");
        }
    }
}
