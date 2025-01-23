using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    
    /// <summary>
    /// 플레이어 차량이 도로에 진입하면 다음 도로를 생성
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other) //도로에 들어왔다면
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SpawnRoad(transform.position+new Vector3(0,0,10f));//현 도로로부터 10떨어진 곳에 만들어줘
        }
    }
    
    
    
    
    /// <summary>
    /// 플레이어 차량이 도로를 벗어나면 해당 도로를 제거
    /// </summary>
    /// <param name="other"></param>

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.DestoryRoad(gameObject);
        }
    }

   
}
