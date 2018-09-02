using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaFacade : Facade {

    public CharaFacade() {
        RegisterCommand(EventsEnum.GetCoin,typeof(CharaGetCoinCommand));
        RegisterMediator(new CharaMediator());
        RegisterProxy(new CharactorInfoProxy());
    }
}
