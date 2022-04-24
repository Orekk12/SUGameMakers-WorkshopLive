using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public GameObject GFXObject;
    public GameObject pivotObj;
    public float Speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - pivotObj.transform.position;
        var mousePositionOn2D = new Vector3(mousePosition.x, mousePosition.y, 0);
        transform.right = mousePositionOn2D - transform.position;
    }
}



//[SerializeField] private GameObject GFXObject;
//[SerializeField] private GameObject pivotObj;
//[SerializeField] private float Speed = 5f;

//private Vector3 defaultScale;
//public float angle;
//private void Start()
//{
//    defaultScale = transform.localScale;
//}

//private void Update()
//{
//    Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - pivotObj.transform.position;

//    var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//    var mousePositionOn2D = new Vector3(mousePosition.x, mousePosition.y, 0);
//    transform.right = mousePositionOn2D - transform.position;

//    RotateBasedOnMousePos();
//}
//private void RotateBasedOnMousePos()
//{
//    Vector3 aimScale = Vector3.one;
//    if (transform.right.x < 0)
//    {
//        aimScale = new Vector3(defaultScale.x, -defaultScale.y, defaultScale.z);
//        GFXObject.transform.localScale = new Vector3(-defaultScale.x, defaultScale.y, defaultScale.z);
//    }
//    else
//    {
//        aimScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z);
//        GFXObject.transform.localScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z);
//    }
//    transform.localScale = aimScale;
//}