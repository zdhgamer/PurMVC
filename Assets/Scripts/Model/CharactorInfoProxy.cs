using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorInfoProxy : Proxy {

    public new const string NAME = "CharactorInfoProxy";

    private PurCharactorInfo info;

    public PurCharactorInfo Info
    {
        get
        {
            return info;
        }

        set
        {
            info = value;
        }
    }


    public CharactorInfoProxy() : base(NAME) {
        Info = new PurCharactorInfo();
    }

    public void GetCoin(int num) {
        Info.Chara_coin += num;
        SendNotification(EventsEnum.CoinChanged, info);

    }

}
