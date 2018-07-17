using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildings : MonoBehaviour {
    public bool isPlaced = false;
    public float height = 10;
	

	void Update () {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            height = height + 1;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            height = height - 1;
        }
        if (!isPlaced)
        {
            //BuildingMenager.isBuilding = true;
            Ray ray = Camera.main.ScreenPointToRay(GameObject.Find("Crosshair").transform.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
                this.transform.position = new Vector3(hit.point.x, height, hit.point.z);
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            isPlaced = true;
            //BuildingMenager.isBuilding = false;
        }
	}
}
