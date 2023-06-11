using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject virtualCam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger) // 지정된 범위안에 플레이어가 들어올 시 카메라 활성화
        {
            virtualCam.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger) // 지정된 범위안에 플레이어가 없어질 시 카메라 비활성화
        {
            virtualCam.SetActive(false);
        }
    }
}
