using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �z��̏�����
        int[] numbers = new int[5];

        // �l�̑��
        numbers[0] = 100;
        numbers[1] = 200;
        numbers[2] = 300;
        numbers[3] = 400;
        numbers[4] = 500;

        // �z��̗v�f�����ɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(numbers[i]);
        }

        // �z��̗v�f���t���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(numbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
