using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class gameClass : MonoBehaviour
{
    private int switchState = 0;
    public GameObject object_binary;
    private List<int> binaryNumbers = new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 };

    public void OnSwitch01clicked(){
        foreach( var binaryNumber in binaryNumbers) {
            Debug.Log( binaryNumber.ToString());
        }
        if(switchState == 0){
            object_binary.transform.DOLocalMoveY(object_binary.transform.localPosition.y - 190, 0.2f);
            switchState = 1;//Math.Sign(object_1.transform.localPosition.x - 150);
            Debug.Log(object_binary.name);
            Debug.Log(switchState);
        } else {
            object_binary.transform.DOLocalMoveY(object_binary.transform.localPosition.y + 190, 0.2f);
            switchState = 0;//Math.Sign(object_1.transform.localPosition.x - 150);
            Debug.Log(object_binary.name);
            Debug.Log(switchState);
        }
        
    }
}
