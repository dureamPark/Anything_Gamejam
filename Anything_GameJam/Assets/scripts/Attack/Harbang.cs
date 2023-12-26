using System.Collections;
using UnityEngine;

public class Harbang : MonoBehaviour
{
    public GameObject song;
    public Transform targetPosition;

    private bool isRising = true;
    private float riseSpeed = 1.0f;

    void Start()
    {
        song.SetActive(false);
    }

    void Update()
    {
        if (isRising)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, riseSpeed * Time.deltaTime);

            if (transform.position == targetPosition.position)
            {
                song.SetActive(true);
                StartCoroutine(DescendAfterDelay());
                isRising = false;
            }
        }
    }

    IEnumerator DescendAfterDelay()
    {
        yield return new WaitForSeconds(13.0f);
        song.SetActive(false);
        while (transform.position.y > -6.5f)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
            yield return null;
        }

        
    }

}
