using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineGenerator : MonoBehaviour
{
    public GameObject linePrefabs;
    public GameObject prefabParent;
    public GameObject ParentPosition;
    DrawWithMouse activeLine;
    public int countLines = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        ParentPosition = Instantiate(prefabParent);
    }

    // Update is called once per frame
    void Update()
    {
       
         if(Input.GetMouseButtonDown(0))
        {
            if(ParentPosition == null) ParentPosition = Instantiate(prefabParent);
            GameObject newLine = Instantiate(linePrefabs);
            newLine.transform.parent = ParentPosition.transform;
            activeLine =  newLine.GetComponent<DrawWithMouse>();
            countLines++;
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if(activeLine != null)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePosition);
        }
    }
}
