using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineAddItem : MonoBehaviour
{
    public GameObject Timecatcher;
    // Start is called before the first frame update
    void Start()
    {
        Timecatcher.SetActive(false);
        StartCoroutine(AddItem());
    }

    IEnumerator AddItem()
    {
        yield return new WaitForSeconds(7f);
        Timecatcher.SetActive(true);
    }

}
