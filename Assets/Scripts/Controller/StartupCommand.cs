using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Core;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class StartupCommand : SimpleCommand,ICommand {

    public override void Execute(INotification notification)
    {
        Debug.Log("启动命令执行");
        base.Execute(notification);

        CharaFacade charaFacade = new CharaFacade();
    }
}
