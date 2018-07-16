using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class money : MonoBehaviour {
    public int money_set;
    public int power_set;
    public Text moneyText;
    public Text powerText;
    public string path;
    void Start()
    {
        path = Application.persistentDataPath + "/" + "PlayerInfo.json";
    }

    PlayerInfo pi = new PlayerInfo();

    void Update () {
        moneyText.text = "Curent money:" + money_set.ToString() + "$";
    }
    public void Addmoney(int MoneyToAdd)
    {
        money_set += MoneyToAdd;
        moneyText.text = "Curent money:" + money_set.ToString() + "$";
    }
    public void RemoveMoney(int MoneyToRemove)
    {
        money_set -= MoneyToRemove;
        moneyText.text = "Curent money:" + money_set.ToString() + "$";
    }
    public void Reset()
    {
        string content = System.IO.File.ReadAllText(path);
        pi = JsonUtility.FromJson<PlayerInfo>(content);
        money_set = pi.money;
        Debug.Log(pi.money);
    }
}
