using UnityEngine;

public class DataController : MonoBehaviour {
    public const int MAX_NUM = 22;
    public Weapon[] weapon;
    public Shield[] shield;
    public Shoes[] shoes;
    
    public int GetAllAttack(int index, int grade, int reinforce) {
        return GetWeaponAttack(index, grade, reinforce) + GetShieldAttack(index, grade, reinforce) + GetShoesAttack(index, grade, reinforce);
    }

    void Start() {
        weapon = new Weapon[MAX_NUM];
        shield = new Shield[MAX_NUM];
        shoes = new Shoes[MAX_NUM];

        for (int i = 0; i < MAX_NUM; i++) { 
            weapon[i] = new Weapon();
            shield[i] = new Shield();
            shoes[i] = new Shoes();
        }
        
        TextAsset weaponJson = Resources.Load("JsonData/weapon") as TextAsset;
        weapon = JsonHelper.FromJson<Weapon>(weaponJson.text);
        TextAsset shieldJson = Resources.Load("JsonData/shield") as TextAsset;
        shield = JsonHelper.FromJson<Shield>(shieldJson.text);
        TextAsset shoesJson = Resources.Load("JsonData/shoes") as TextAsset;
        shoes = JsonHelper.FromJson<Shoes>(shoesJson.text);

    }


    private int GetWeaponAttack(int index, int grade, int reinforce) {
        return weapon[index].grade[grade].reinforce[reinforce].attack;
    }

    private int GetShieldAttack(int index, int grade, int reinforce) {
        return shield[index].grade[grade].reinforce[reinforce].attack;
    }

    private int GetShoesAttack(int index, int grade, int reinforce) {
        return shoes[index].grade[grade].reinforce[reinforce].attack;
    }
    
}
