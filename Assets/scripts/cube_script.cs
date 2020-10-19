using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cube_script : MonoBehaviour {

	public float gridSize = 0.1f;
	public GameObject colorCubePrefab;
	public int cubeFidelity = 10;
	public int showIndex = 0;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < cubeFidelity; x++) {
			for (int y = 0; y < cubeFidelity; y++){ 
				for (int z = 0; z < cubeFidelity; z++){
					GameObject newCube = Instantiate(colorCubePrefab);
					newCube.transform.position = new Vector3(x * gridSize, y * gridSize, z * gridSize);
					newCube.transform.localScale = new Vector3(gridSize * 0.9f, gridSize * 0.9f, gridSize * 0.9f);
					newCube.GetComponent<Renderer>().material.SetColor("_Color", new Color(x / (float)cubeFidelity, y / (float)cubeFidelity,  z / (float)cubeFidelity, 1f));
					newCube.transform.parent = transform;
				}
			}
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		// get children
		foreach (Transform child in transform)
		{
			if (child.localPosition.x < showIndex * gridSize) {
				child.gameObject.SetActive(false);
			} else {
				child.gameObject.SetActive(true);
			}
		}

		if (Input.GetKeyDown(KeyCode.K))
        {
			showIndex = showIndex - 1;
		} 
		if (Input.GetKeyDown(KeyCode.L))
		{
			showIndex = showIndex + 1;
		}
	}
}
