using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foundation1x1 : MonoBehaviour {
    bool isPlaced;
	

	void Update () {
        if (!isPlaced)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                this.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }
        }
	}
}
