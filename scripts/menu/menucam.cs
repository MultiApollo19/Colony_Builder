using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menucam : MonoBehaviour {
    Scene menu;
    public float RotateAmount = 15f;
    bool active;

    public void OrbitCamera()
    {
            Vector3 target = Vector3.zero; //this is the center of the scene, you can use any point here
            float x_rotate = Time.deltaTime * RotateAmount;
            OrbitCamera(target, -x_rotate, 0);
        
    }

    public void OrbitCamera(Vector3 target, float y_rotate, float x_rotate)
    {
        Vector3 angles = transform.eulerAngles;
        angles.z = 0;
        transform.eulerAngles = angles;
        transform.RotateAround(target, Vector3.up, y_rotate);
        transform.RotateAround(target, Vector3.left, x_rotate);

        transform.LookAt(target);
    }
    void Update()
    {
        menu = SceneManager.GetActiveScene();
        if (menu.name == "Menu")
        {
             active = true;
        }
        if (active == true)
        {
            OrbitCamera();
        }

    }
}
