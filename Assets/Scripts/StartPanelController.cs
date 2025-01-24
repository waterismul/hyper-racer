using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanelController : MonoBehaviour
{
    public delegate void StartGameDelegate();//델리게이트사용
    public event StartGameDelegate OnStartButtonClick;
    
    public void OnClickStartButton()
    {
        OnStartButtonClick?.Invoke();
    }
}
