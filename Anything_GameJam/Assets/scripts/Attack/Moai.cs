using System.Collections;
using UnityEngine;

public class Moai : MonoBehaviour
{
    public GameObject laser;
    public Transform targetPosition;
    private Animator animator;
    public bool isDown = false; //이거 관리 필요
    private float downSpeed = 10.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        laser.SetActive(false);
    }

    void Update()
    {
        if (isDown)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, downSpeed * Time.deltaTime);

            if (transform.position == targetPosition.position)
            {
                animator.SetBool("isAttack", true);
                laser.SetActive(true);
                StartCoroutine(AscendAfterDelay());
                isDown = false;
            }
        }
    }

    IEnumerator AscendAfterDelay()
    {
        yield return new WaitForSeconds(4f);
        laser.SetActive(false);
        animator.SetBool("isAttack", false);

        while (transform.position.y < 9f) // 변경된 부분: 9까지 올라가도록 수정
        {
            transform.Translate(Vector3.up * downSpeed * Time.deltaTime); // 위로 올라가도록 수정
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, 9f, transform.position.z); // 정확한 위치로 이동
    }

}
