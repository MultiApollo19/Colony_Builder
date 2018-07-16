using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saveloadplayer : MonoBehaviour
{
    private string path;
    private string filename = "PlayerInfo.json";
    public int money;

    void Start()
    {
        path= Application.persistentDataPath + "/" + filename;
    }
    PlayerInfo pi = new PlayerInfo();
    public void Save()
    {
        //id z triger scr
        pi.money = GetComponent<money>().money_set;
        Debug.Log(pi.money);
        //zapis
        string content = JsonUtility.ToJson(pi, true);
        System.IO.File.WriteAllText(path, content);
    }
    public void Load()
    {
        string content = System.IO.File.ReadAllText(path);
        pi = JsonUtility.FromJson<PlayerInfo>(content);

    }
}