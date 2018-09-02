using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMediator : Mediator
{
    private Button start_btn;

    public StartMediator() {
        start_btn = GameUtility.GetChildComponent<Button>(ViewRoot.Instace.gameObject, "start_btn");

        start_btn.onClick.AddListener(OnStartClick);
    }

    public void OnStartClick() {
        Debug.Log("开始按钮点击");
        SendNotification(EventsEnum.STARTUP);
    }

}
