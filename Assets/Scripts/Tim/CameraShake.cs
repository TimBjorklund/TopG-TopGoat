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
            //Startar rutinen för att skärmen ska skaka
            StartCoroutine(Shaking());
        }
    }
    //En rutin, i denna rutin så skakar skärmen
    IEnumerator Shaking()
    {
        //Sparar in vart Kameran startar så att skakandet dåt
        Vector3 startPosition = transform.position;
        //Skulle koden använts förut skulle inte den fungera eftersom att tiden hade varit över duration.
        float elapsedTime = 0f;
        //När  elapsedTime är mindre än den insatta durationen kommer koden under vara igång.
        while (elapsedTime < duration)
        {
            //plussar på Time.deltaTime på elapsedTime.
            elapsedTime += Time.deltaTime;
            //Sätter positionen på kameran till en random position innom en sphere med standard radien 1 men som sedan gångras med det man vill ha
            transform.position = startPosition + (Random.insideUnitSphere * Radius);
            yield return null;
        }
        //Återställer kamerans position tillbaka till den kameran började på
        transform.position = startPosition;
    }
}
// Tim.B