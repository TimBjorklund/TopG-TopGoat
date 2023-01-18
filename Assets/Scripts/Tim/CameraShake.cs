using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Duration
    public float duration = 1f;
    // Radius
    public float Radius = 1f;
    // Bool antinge true eller false
    public bool start = false;
    void Update()
    {
        if (start == true)
        {
            start = false;
            //Startar rutinen f�r att sk�rmen ska skaka
            StartCoroutine(Shaking());
        }
    }
    //En rutin, i denna rutin s� skakar sk�rmen
    IEnumerator Shaking()
    {
        //Sparar in vart Kameran startar s� att skakandet d�t
        Vector3 startPosition = transform.position;
        //Skulle koden anv�nts f�rut skulle inte den fungera eftersom att tiden hade varit �ver duration.
        float elapsedTime = 0f;
        //N�r  elapsedTime �r mindre �n den insatta durationen kommer koden under vara ig�ng.
        while (elapsedTime < duration)
        {
            //plussar p� Time.deltaTime p� elapsedTime.
            elapsedTime += Time.deltaTime;
            //S�tter positionen p� kameran till en random position innom en sphere med standard radien 1 men som sedan g�ngras med det man vill ha
            transform.position = startPosition + (Random.insideUnitSphere * Radius);
            yield return null;
        }
        //�terst�ller kamerans position tillbaka till den kameran b�rjade p�
        transform.position = startPosition;
    }
}
// Tim.B