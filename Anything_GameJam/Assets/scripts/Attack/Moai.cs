using System.Collections;
using UnityEngine;

public class Moai : MonoBehaviour
{
    public GameObject laser;
    public Transform targetPosition;
    private Animator animator;
    public bool isDown = false; //�̰� ���� �ʿ�
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

        while (transform.position.y < 9f) // ����� �κ�: 9���� �ö󰡵��� ����
        {
            transform.Translate(Vector3.up * downSpeed * Time.deltaTime); // ���� �ö󰡵��� ����
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, 9f, transform.position.z); // ��Ȯ�� ��ġ�� �̵�
    }

}
