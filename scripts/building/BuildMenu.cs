using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BuildMenu : MonoBehaviour {
    public static int bs;
    public GameObject player;
    public BuildingMenager bm;
    private static bool active = false;
    public GameObject buildui;
    public Text moneystat;
    public GameObject EventSystem;
    public GameObject moneyui;
    public GameObject sterinfo;
    private  int moneyBu;
    // Update is called once per frame

    BuildingMenager buildmenager;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update () {
        moneyBu = EventSystem.GetComponent<money>().money_set;
        moneystat.text = "Current money:" + moneyBu + "$";
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (active)
            {
                Resume();
            }
            else
            {
                
                Pause();
            }
        }
        
	}
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        Cursor.visible = false;
        player.GetComponent<playerMov>().enabled = true;
        buildui.SetActive(false);
        moneyui.SetActive(true);
        sterinfo.SetActive(true);
        active = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        Cursor.visible = true;
        sterinfo.SetActive(false);
        player.GetComponent<playerMov>().enabled = false;
        moneyui.SetActive(false);
        buildui.SetActive(true);
        active = true;
    }
}
