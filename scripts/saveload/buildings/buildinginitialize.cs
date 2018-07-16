using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class buildinginitialize : MonoBehaviour
{
    public Text load_save;
    private string path;
    private string filename = "BuildingsInfo.json";
    //dotyczy zakładek
    [HideInInspector]
    public int currentTab;
    //budynki/ulepszenia
    //cop_1
    public GameObject cop_1;//budynek
    public GameObject cop_1ac;//przycisk aktywujący
    public GameObject cop_1ne;//przycisk następny
    //antena_1
    public GameObject antena_1;
    public GameObject antena_1ac;
   // public GameObject antena_1ne;
    //antena_2
    public GameObject antena_2;
    public GameObject antena_2ac;
    //public GameObject antena_2ne;
    //antena_3
    //public GameObject antena_3;
   // public GameObject antena_3ac;
   // public GameObject antena_3ne;
    //antena_4
    //public GameObject antena_4;
    //public GameObject antena_4ac;
   // public GameObject antena_4ne;
    //antena_5
    //public GameObject antena_5;
    //public GameObject antena_5ac;
   // public GameObject antena_5ne;
    //table_1
    public GameObject table_1;//ulepszenie
    public GameObject table_1ac;//przycisk aktywujący
  //  public GameObject table_1ne;//przycisk następny

    BuildingsInfo bi = new BuildingsInfo();
    void Start()
    {
        path = Application.persistentDataPath + "/" + filename;
        //wyszukiwanie budynku/ulepszenia
        //cop_1,linijka

    }
    public void Initialize()
    {
        //wczytaj dane
        string content = System.IO.File.ReadAllText(path);
        bi = JsonUtility.FromJson<BuildingsInfo>(content);
        Debug.Log(bi.act0);
        Debug.Log(bi.act1);
        load_save.text = "Game   loaded";
        if (bi.act0 == true)
        {
            cop_1.SetActive(true);//budynek
            cop_1ac.SetActive(false);//przycisk aktywujacy
            cop_1ne.SetActive(true);//przycisk następny

        }
        if (bi.act0 == false)
        {
            cop_1.SetActive(false);//budynek
            cop_1ac.SetActive(true);//przycisk aktywujacy
            cop_1ne.SetActive(false);//przycisk następny
        }
        if (bi.act1 == true)
        {
            table_1.SetActive(true);//budynek
            table_1ac.SetActive(false);//przycisk aktywujacy
            //table_1ne.SetActive(true);//przycisk następny

        }
        if (bi.act1 == false)
        {
            table_1.SetActive(false);//budynek
            if (bi.act0 == false)
            {
                table_1ac.SetActive(false);
            }
            if (bi.act0 == true)
            {
                table_1ac.SetActive(true);
            }
            //table_1ne.SetActive(false);//przycisk następny
        }
        if (bi.act2 == true)
        {
            antena_1.SetActive(true);//budynek
            antena_1ac.SetActive(false);//przycisk aktywujacy
            //antena_1ne.SetActive(true);//przycisk następny

        }
        if (bi.act2 == false)
        {
            antena_1.SetActive(false);//budynek
            antena_1ac.SetActive(true);//przycisk aktywujacy
           //antena_1ne.SetActive(false);//przycisk następny

        }
        if (bi.act3 == true)
        {
            antena_2.SetActive(true);//budynek
            antena_2ac.SetActive(false);//przycisk aktywujacy
            //antena_1ne.SetActive(true);//przycisk następny

        }
        if (bi.act3 == false)
        {
            antena_2.SetActive(false);//budynek
            antena_2ac.SetActive(true);//przycisk aktywujacy
                                       //antena_1ne.SetActive(false);//przycisk następny

        }
    }
}