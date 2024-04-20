using UnityEngine;

public class звук_конца : MonoBehaviour
{
    public float yThreshold = 0f; // Пороговое значение по оси Y, ниже которого будет воспроизводиться звук
    public AudioClip soundClip; // Звук для воспроизведения

    private bool hasPlayed = false; // Флаг, чтобы убедиться, что звук воспроизводится только один раз

    void Update()
    {
        // Проверяем, если позиция шарика по оси Y меньше порогового значения
        if (transform.position.y < yThreshold && !hasPlayed)
        {
            // Если да, воспроизводим звук
            AudioSource.PlayClipAtPoint(soundClip, transform.position);
            hasPlayed = true; // Устанавливаем флаг, чтобы звук воспроизводился только один раз
        }
    }
}
