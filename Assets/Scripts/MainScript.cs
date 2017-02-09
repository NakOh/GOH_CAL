using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {
    public Text attack;
    public Text health;
    public Text skill_percent;
    public Text leaderAttack_percent;
    public Text leaderHealth_percent;
    public Text buff;

    private int weaponKind, weaponInforce, shiledKind, shieldInforce, ShoesKind, ShoesInforce;

    public void WeaponKinds_Changed(int index) {

    }

    public void WeaponReinforce_Changed(int index) {

    }

    public void ShiledKinds_Changed(int index) {

    }

    public void ShieldReinforce_Changed(int index) {

    }


    public void ShoesKinds_Changed(int index) {

    }

    public void ShoesReinforce_Changed(int index) {

    }

    public void LeaderKinds_Changed(int index) {

    }

    public void Complete() {
        int attacks = int.Parse(attack.text);
        int healths = int.Parse(health.text);
        int skill_percents = int.Parse(skill_percent.text);
        int leaderAttack_percents = int.Parse(leaderAttack_percent.text);
        int leaderHealth_percents = int.Parse(leaderHealth_percent.text);
        int buffs = int.Parse(buff.text);


    }

}
