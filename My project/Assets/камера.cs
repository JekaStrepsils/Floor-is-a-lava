using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class камера : MonoBehaviour
{
    public Transform target; // Посилання на об'єкт, за яким камера буде слідкувати
    public Vector3 offset;
    public float distance = 5.0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && target.position.y > 1.6)
        {
            // Отримати нову позицію для камери, яка знаходиться на певній відстані від цілі
            Vector3 targetPosition = target.position - transform.forward * distance + offset;

            // Змінити позицію камери на нову позицію
            transform.position = targetPosition;

            // Забезпечити те, що камера завжди дивиться на ціль
            transform.LookAt(target);
        }
    }
}