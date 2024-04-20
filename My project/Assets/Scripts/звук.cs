using UnityEngine;

public class звук : MonoBehaviour
{
    public float yThreshold = 0f; // Пороговое значение по оси Y, ниже которого будет воспроизводиться звук
    public AudioClip soundClip; // Звук для воспроизведения

    private AudioSource audioSource;

    void Start()
    {
        // Получаем компонент AudioSource для воспроизведения звука
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Проверяем, если позиция шарика по оси Y меньше порогового значения
        if (transform.position.y > yThreshold)
        {
            // Если да, воспроизводим звук
            if (audioSource != null && soundClip != null && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(soundClip);
            }
        }
    }
}
