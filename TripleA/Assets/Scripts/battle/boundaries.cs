using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    private Vector2 Bounds;
    private float objWid;
    private float objHeig;
    // Start is called before the first frame update
    void Start()
    {
        Bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objWid = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objHeig = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewpos = transform.position;
        viewpos.x = Mathf.Clamp(viewpos.x, Bounds.x + objWid, Bounds.x = -1 - objWid);
        viewpos.y = Mathf.Clamp(viewpos.y, Bounds.x + objHeig, Bounds.y = -1 - objHeig);
    }
}
