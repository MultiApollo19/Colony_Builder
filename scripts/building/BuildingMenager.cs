using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenager : MonoBehaviour {
    public static bool isBuilding = false;
    public static float buildingmen;
    public GameObject Foundation1x1;
	
	void Update () {
        if (buildingmen == 1 && !isBuilding)
        {
            isBuilding = true;
            Instantiate(Foundation1x1, Vector3.zero, Foundation1x1.transform.rotation);
        }
	}
}
