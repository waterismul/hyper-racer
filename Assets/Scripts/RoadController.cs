using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoadController : MonoBehaviour
{
    [SerializeField] private GameObject[] gasObjects;
    
    private void OnEnable()//비활성화 될때마다 호출
    {
        //모든 가스 아이템 비활성
        foreach (var gasObject in gasObjects)
        {
            gasObject.SetActive(false);
        }
    }
    
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

    /// <summary>
    /// 랜덤으로 가스 아이템을 표시
    /// </summary>
    public void SpawnGas()
    {
        
        int index = Random.Range(0, gasObjects.Length);
        gasObjects[index].SetActive(true);
    

        
    }

   
}
