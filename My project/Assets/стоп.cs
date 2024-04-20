using UnityEngine;

public class стоп : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        // Проверяем, если позиция шарика по оси Y меньше 0
        if (transform.position.y < 0)
        {
            // Если да, то скрываем шарик
            gameObject.SetActive(false);
            Debug.Log("Мячик сгорів в лаві"); // Выводим сообщение в консоль (можно заменить на свой код)
            audioSourse.Play();
        }
    }
}
