using UnityEngine;

public class textrotate : MonoBehaviour {
    public Transform target;
    private void Start()
    {
        transform.Rotate(180,0,0);
    }
    // Update is called once per frame
    void Update () {
        Vector3 v = target.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(target.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
