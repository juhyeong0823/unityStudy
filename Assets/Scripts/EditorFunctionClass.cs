using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorFunctionClass : MonoBehaviour
{
    public GameObject testPrefab;
    [SerializeField]
    private float distance;
    [SerializeField]
    private int count;


    public void GeneratePrefab()
    {
        GameObject obj = Instantiate(testPrefab, transform.position, Quaternion.identity,this.transform);
        obj.transform.localPosition = new Vector3(distance*count, 0, 0);
        count++;
    }
}
