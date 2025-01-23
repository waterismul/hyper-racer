using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]private int gas = 100;
    [SerializeField]private float moveSpeed = 1f;

    public int Gas
    {
        get => gas;
    }

    void Start()
    {
        StartCoroutine(GasCoroutine());
    }

    IEnumerator GasCoroutine()
    {
        while (true)
        {
            gas -= 10;
            if (gas <= 0)
            {
                break;
            }
            
            yield return new WaitForSeconds(1f);
        }
        
    }
    
    /// <summary>
    /// 자동차 이동 메서드
    /// </summary>
    /// <param name="direction"></param>
    public void Move(float direction)
    {
        transform.Translate(Vector3.right*(direction*moveSpeed*Time.deltaTime));//얼만큼 이동하느냐
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f), 0, transform.position.z);//순간이동
    }
    
    /// <summary>
    /// 가스 아이템 획득시 호출되는 메서드
    /// </summary>
    /// <param name="other"></param>

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gas"))
        {
            gas += 30;
            
            
            //TODO: 가스 아이템 제거
            
        }
    }
}
