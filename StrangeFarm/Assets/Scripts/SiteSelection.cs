using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiteSelection : MonoBehaviour
{
    //private GameObject[] siteBtns;

    private int gridSize = 5;
    public GameObject buttonPrefab;
    public RectTransform firstPosition;
    private RectTransform newPosition;
    private RectTransform clonedfirstposition;

    private void Awake()
    {
        if (firstPosition)
        {
            // Clone the initial position to make it independent
            clonedfirstposition = Instantiate(firstPosition);

            // Use the cloned position for the grid creation
            newPosition = clonedfirstposition;
        }
        
    }

    void Start()
    {
        if (firstPosition)
        {
            CreateGrid();
        }

    }


    void Update()
    {
        
    }

    private void CreateGrid()
    {
        RectTransform canvasRect = GameObject.Find("Canvas").GetComponent<RectTransform>();

        for (int row = 0; row < gridSize; row++)
        {
            for (int col = 0; col < gridSize; col++)
            {
                // Instantiate button with Canvas as parent
                GameObject buttonObj = Instantiate(buttonPrefab, canvasRect);

                // Set RectTransform position
                buttonObj.GetComponent<RectTransform>().anchoredPosition = newPosition.anchoredPosition;

                if (col == gridSize - 1)
                {
                    newPosition.anchoredPosition = new Vector2(firstPosition.anchoredPosition.x, newPosition.anchoredPosition.y - 100);
                }
                else
                {
                    newPosition.anchoredPosition = new Vector2(newPosition.anchoredPosition.x + 100, newPosition.anchoredPosition.y);
                }

                // Set button's Text (here, displaying an integer)
                buttonObj.GetComponentInChildren<Text>().text = ((row * gridSize) + col + 1).ToString();

            }
        }
    }

}


