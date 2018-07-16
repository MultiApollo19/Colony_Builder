using UnityEngine;


public class trigersript : MonoBehaviour

{

    public GameObject aktywuj_obiekt;
    public GameObject aktywuj_przycisk;
    public int money_remove;
    public GameObject EventSystem;
    public GameObject marktext;
    public GameObject marktextnext;
    public GameObject mact;
    public GameObject mark;


    void OnTriggerEnter(Collider other) {
		this.gameObject.SetActive (false);
        EventSystem.GetComponent<money>().RemoveMoney(money_remove);
        active_ob();
        active_bt();
        mact.SetActive(true);
        mark.SetActive(false);
        marktextnext.SetActive(true);
        marktext.SetActive(false);

    }
    public void active_ob()
    {
        aktywuj_obiekt.SetActive(true);
    }
    public void active_bt()
    {
        aktywuj_przycisk.SetActive(true);
    }
}
