using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeSlider : MonoBehaviour
{
	public GameObject cubeRef;
    private cube_script scriptRef;

    // Start is called before the first frame update
    void Start()
    {
        scriptRef = cubeRef.GetComponent<cube_script>(); 
        // GetComponent<Renderer>().material.SetColor("_Color", new Color(.5f, .5f, .5f, .1f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3((scriptRef.showIndex * scriptRef.gridSize)-(float).05, (float)-.116, (float).116);
    }
}
