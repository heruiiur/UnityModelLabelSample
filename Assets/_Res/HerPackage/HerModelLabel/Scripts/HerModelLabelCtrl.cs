using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HerModelLabelCtrl : MonoBehaviour
{
    public Transform cameraTarget;
    public bool isLookAt = true;
    public bool isrotate = true;
    public EnumLabelCanvasType LabelType;

    public Transform TransContent;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), Mathf.Abs(this.transform.localScale.y), Mathf.Abs(this.transform.localScale.z));

        switch (LabelType)
        {
            case EnumLabelCanvasType.LeftTop:
                this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
                TransContent.localScale = new Vector3(1, -1, 1);
                break;
            case EnumLabelCanvasType.LeftBottom:
                this.transform.localScale = new Vector3(this.transform.localScale.x, -this.transform.localScale.y, this.transform.localScale.z);
                TransContent.localScale = new Vector3(1, 1, 1);
                break;
            case EnumLabelCanvasType.RightTop:
                this.transform.localScale = new Vector3(-this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
                TransContent.localScale = new Vector3(-1, -1, 1);
                break;
            case EnumLabelCanvasType.RightBottom:
                this.transform.localScale = new Vector3(-this.transform.localScale.x, -this.transform.localScale.y, this.transform.localScale.z);
                TransContent.localScale = new Vector3(-1, 1, 1);
                break;
            default:
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (isLookAt)
        {
            this.transform.LookAt(cameraTarget);
        }
        if (isrotate)
        {
            this.transform.localEulerAngles =
        new Vector3(this.transform.localEulerAngles.x,
    cameraTarget.localEulerAngles.y,
    this.transform.localEulerAngles.z);
        }

    }
}

public enum EnumLabelCanvasType
{
    LeftTop,
    LeftBottom,
    RightTop,
    RightBottom
}
