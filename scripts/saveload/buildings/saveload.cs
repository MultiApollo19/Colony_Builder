using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class saveload : MonoBehaviour
{
    private string path;
    private string filename = "BuildingsInfo.json";
    public GameObject ts;
    public Text load_save;
    public GameObject es;
    //id
    public GameObject actb0;
    public GameObject actb1;
    public GameObject actb2;
    public GameObject actb3;

    void Start()
    {
        path= Application.persistentDataPath + "/" + filename;
    }
    BuildingsInfo bi = new BuildingsInfo();
    public void Save()
    {
        //id z triger scr
        Debug.Log(bi.act0);
        Debug.Log(bi.act1);
        if (actb0.active)
        {
            bi.act0 = true;
        }
        if (actb1.active)
        {
            bi.act1 = true;
        }
        if (actb2.active)
        {
            bi.act2 = true;
        }
        if (actb3.active)
        {
            bi.act3 = true;
        }
        //zapis
        string content = JsonUtility.ToJson(bi, true);
        System.IO.File.WriteAllText(path, content);
        load_save.text = "Game   saved";

    }
    public void Load()
    {
        string content = System.IO.File.ReadAllText(path);
        bi = JsonUtility.FromJson<BuildingsInfo>(content);

    }
}