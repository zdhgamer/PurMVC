using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurCharactorInfo  {

    private int chara_coin;

    public int Chara_coin
    {
        get
        {
            return chara_coin;
        }

        set
        {
            chara_coin = value;
        }
    }


    public PurCharactorInfo() {

    }

    public PurCharactorInfo( int chara_coin) {
        this.chara_coin = chara_coin;
    }
}
