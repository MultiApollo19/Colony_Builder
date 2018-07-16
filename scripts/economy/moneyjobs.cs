using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyjobs : MonoBehaviour {
    public int money_add;
    public GameObject EventSystem;
    public GameObject zarabiający;
    public GameObject money_part;


    // Use this for initialization
    void Start () {
            if (zarabiający.active)
            {
                InvokeRepeating("moneyadd", 1, 10);
                money_part.SetActive(true);
            }
	}

    void moneyadd()
    {
        EventSystem.GetComponent<money>().Addmoney(money_add);
    }

}
