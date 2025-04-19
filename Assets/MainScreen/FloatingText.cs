using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    // 텍스트의 기본 위치와 상승 속도
    public float floatSpeed = 1f;  // 올라가는 속도
    public float floatHeight = 10f; // 올라갈 최대 높이

    private Vector3 startPosition;

    void Start()
    {
        // 텍스트의 초기 위치 저장
        startPosition = transform.position;
    }

    void Update()
    {
        // 위로 계속 올라가게 하는 애니메이션
        float newY = Mathf.Sin(Time.time * floatSpeed) * floatHeight;  // 사인 함수로 부드럽게 위아래 움직이기
        transform.position = startPosition + new Vector3(0, newY, 0); // X, Z는 그대로 두고 Y만 변화
    }
}
