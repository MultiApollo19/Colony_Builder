using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BuildMenu : MonoBehaviour {
    public float building_set;
    public GameObject player;
    private static bool active = false;
    public GameObject buildui;
    public Text moneystat;
    public GameObject EventSystem;
    public GameObject moneyui;
    private int moneyBu;
    // Update is called once per frame
   
	void Update () {
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
    void Resume()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        player.GetComponent<playerMov>().enabled = true;
        buildui.SetActive(false);
        moneyui.SetActive(true);
        active = false;
    }
    void Pause()
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
        moneyBu = EventSystem.GetComponent<money>().money_set;
        moneystat.text = "Current money:" + moneyBu + "$";
        player.GetComponent<playerMov>().enabled = false;
        moneyui.SetActive(false);
        buildui.SetActive(true);
        active = true;
    }
    public void SetBuilding(float building)
    {
        Resume();
        BuildingMenager.isBuilding = true;
        BuildingMenager.buildingmen = building;
        Debug.Log("Wybrano: " + BuildingMenager.buildingmen);
    }
}
