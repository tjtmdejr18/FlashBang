using UnityEngine;

public class ObjectDestroyHandler : MonoBehaviour
{
    public GameObject panel; // 표시할 패널

    private void OnDestroy()
    {
        // 오브젝트가 파괴될 때 호출되는 메소드
        if (panel != null)
        {
            panel.SetActive(true); // 패널 활성화
        }
    }
}
