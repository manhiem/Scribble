using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilizePos : MonoBehaviour
{
    public Vector3 Origpos;
    // Start is called before the first frame update
    void Start()
    {
        Origpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Origpos * Time.deltaTime * 0.001f);
    }
}
