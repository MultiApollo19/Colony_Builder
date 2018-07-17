using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] placeableObjectPrefabs;
    private GameObject currentbuilding;
    public static bool isBuilding = false;

    void Update()
    {
        
    }
    public void buduj(int id)
    {

        
        currentbuilding = placeableObjectPrefabs[id];
        Instantiate(currentbuilding, Vector3.zero, transform.rotation);
            
        
    }
}
