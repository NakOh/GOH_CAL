using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {
    public DataController dataCont;

    public Text attack_text;
    public Text health_text;
    public Text skill_percent_text;
    public Text leaderAttack_percent_text;
    public Text leaderHealth_percent_text;
    public Text buff_text;

    private int weaponKind , weaponInforce, weaponGrade, shieldKind, shieldInforce, shieldGrade, shoesKind, shoesInforce, shoesGrade, leaderKind, buffKind;

    private Weapon weapon;
    private Shield shield;
    private Shoes shoes;

    public Text finalAttack_text;
    public Text finalHealth_text;
    public Text finalSkillDamage_text;

    public GameObject popup;

    void Start() {
        weaponKind = 0;
        weaponInforce = 0;
        weaponGrade = 0;
        shieldKind = 0;
        shieldInforce = 0;
        shieldGrade = 0;
        shoesKind = 0;
        shoesInforce = 0;
        shoesGrade = 0;
        leaderKind = 0;
        buffKind = 0;
    }

    public void WeaponKinds_Changed(int index) {
        weaponKind = index;
    }

    public void WeaponReinforce_Changed(int index) {
        weaponInforce = index;
    }

    public void WeaponGrade_Changed(int index) {
        weaponGrade = index;
    }

    public void ShieldKinds_Changed(int index) {
        shieldKind = index;
    }

    public void ShieldReinforce_Changed(int index) {
        shieldInforce = index;
    }

    public void ShieldGrade_Changed(int index) {
        shieldGrade = index;
    }

    public void ShoesKinds_Changed(int index) {
        shoesKind = index;
    }

    public void ShoesReinforce_Changed(int index) {
        shoesInforce = index;
    }

    public void ShoesGrade_Changed(int index) {
        shoesGrade = index;
    }

    public void LeaderKinds_Changed(int index) {
        leaderKind = index;
    }

    public void BuffKinds_Changed(int index) {
        buffKind = index;
    }

    public void Complete() {
        int attack = int.Parse(attack_text.text);
        int health = int.Parse(health_text.text);
        int skill_percent = int.Parse(skill_percent_text.text);
        float leaderAttack_percent = float.Parse(leaderAttack_percent_text.text);
        int leaderHealth_percent = int.Parse(leaderHealth_percent_text.text);
        int buff = int.Parse(buff_text.text);

        selectWeapon();
        selectShield();
        selectShoes();

        float finalAttack = CalAttack(attack, buff, leaderAttack_percent);
        float addPercent = CalSkillPercent(skill_percent, leaderAttack_percent);
        float skillPercent = skill_percent / 100;

        int realFinalDamage = Convert.ToInt32(finalAttack * skillPercent * (1 + addPercent));

        Debug.Log("finalAttack : " + finalAttack);
        Debug.Log("addPercent : " + addPercent);
        Debug.Log("skillPercent : " + skillPercent);
        Debug.Log("realFinalDamage : " + finalAttack * skillPercent * (1 + addPercent));
        finalSkillDamage_text.text = realFinalDamage.ToString();

        popup.SetActive(true);
    }
    
    private float CalAttack(int attack, int buff, float leader) {

        float finalAttack = (attack + weapon.grade[weaponGrade - 1].reinforce[weaponInforce - 1].attack +
            shield.grade[shieldGrade - 1].reinforce[shieldInforce - 1].attack +
            shoes.grade[shoesGrade - 1].reinforce[shoesInforce - 1].attack);

        if (buffKind == 1)
            finalAttack = finalAttack * ((float)buff/100);

        if (leaderKind == 1)
            finalAttack = finalAttack * leader;

        return finalAttack;
    }

    private float CalSkillPercent(int buff, float leader) {
        float percent = 0;

        if (buffKind == 2)
            percent = buff / 100;

        if (leaderKind == 2)
            percent = percent + (leader - 1);


        return percent;
    }

    private void selectWeapon() {
        if(weaponKind != 0) {
            weapon = dataCont.weapon[weaponKind-1];
        }

    }

    private void selectShield() {
        if(shieldKind != 0) {
            shield = dataCont.shield[shieldKind-1];
        }

    }

    private void selectShoes() {
        if(shoesKind != 0) {
            shoes = dataCont.shoes[shoesKind - 1];
        }

    }

    public void close() {
        popup.SetActive(false);
    }

}
