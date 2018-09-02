using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class CharaGetCoinCommand : SimpleCommand {

    public override void Execute(INotification notification)
    {
        base.Execute(notification);
        Debug.Log("执行得到金币");
        CharactorInfoProxy proxy = (CharactorInfoProxy)Facade.RetrieveProxy(proxyName: CharactorInfoProxy.NAME);
        proxy.GetCoin(1);
    }
}
