using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppFacade : Facade {

    private static AppFacade _instance;

    public new static AppFacade Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new AppFacade();
                    }
                }
            }
            return _instance;
        }
    }

    public AppFacade() : base()
    {

    }


    //启动
    public void StartUp() {
        Debug.Log("开始");
    }

    protected override void InitializeView()
    {
        Debug.Log("注册开始界面中介");
        base.InitializeView();
        RegisterMediator(new StartMediator());
    }

    protected override void InitializeController()
    {
        Debug.Log("注册开始事件");
        base.InitializeController();
        RegisterCommand(EventsEnum.STARTUP, typeof(StartupCommand));

    }

}
