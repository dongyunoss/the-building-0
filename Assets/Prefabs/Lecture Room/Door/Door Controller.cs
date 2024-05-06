using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float angle = 0f; // ��ǥ ����, 0 ~ 90��
    public float speed = 200f; // ���� ������ �ӵ�

    // Update is called once per frame
    void Update()
    {
        // ������ 0 ~ 90�� ���̷� ����
        if (angle < 0f) angle = 0f;
        if (angle > 90f) angle = 90f;

        // transform.eulerAngles[1]�� Transform ������Ʈ�� Rotation�� ���� Y���� �ǹ�, �� ���� ����
        float currentAngle = transform.eulerAngles[1];

        // ���� ������ ��ǥ�ϴ� �������� ���� �� (- 1�� ����ϴ� ���� ����)
        if (currentAngle < angle - 1) transform.Rotate(Vector3.up, speed * Time.deltaTime); // ����

        // ���� ������ ��ǥ�ϴ� �������� Ŭ �� (+ 1�� ����ϴ� ���� ����)
        else if (currentAngle > angle + 1) transform.Rotate(Vector3.down, speed * Time.deltaTime); // �ݱ�

        // ���� ������ 0 ~ 90���� �ƴ� ��, 0�� �Ʒ��� ������ �ƴ϶� 360���� ���� �ϳ��� ��.
        // ���� speed�� �ʹ� ������ �� ������ �� ���ϴ� ������ Ŀ�� �߻�
        if (currentAngle > 90f) transform.rotation = Quaternion.Euler(0f, angle, 0f); // ��ǥ ������ �ٷ� ����
    }
}
