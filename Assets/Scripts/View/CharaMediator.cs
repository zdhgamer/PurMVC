using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaMediator : Mediator {

    public new const string NAME = "CharaMediator";

    private Text now_coin_text;

    private Button get_coin_btn;

    public CharaMediator() : base(NAME) {
        now_coin_text = GameUtility.GetChildComponent<Text>(ViewRoot.Instace.gameObject, "now_coin_text");
        get_coin_btn = GameUtility.GetChildComponent<Button>(ViewRoot.Instace.gameObject, "get_coin_btn");

        get_coin_btn.onClick.AddListener(onGetCoinClick);
    }


    public void onGetCoinClick() {
        Debug.Log("得到金币按钮点击");
        SendNotification(EventsEnum.GetCoin);
    }

    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(EventsEnum.CoinChanged);
        return list;
    }

    public override void HandleNotification(INotification notification)
    {
        base.HandleNotification(notification);
        switch (notification.Name) {
            case EventsEnum.CoinChanged:
                PurCharactorInfo info = notification.Body as PurCharactorInfo;
                now_coin_text.text = info.Chara_coin.ToString();
                break;
        }
    }


}
