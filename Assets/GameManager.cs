using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;

    [SerializeField] int totalPipes = 0;

    // Start is called before the first frame update
    void Start()
    {
        //roll calls all the pipes that are children of the parent game object
        totalPipes = PipesHolder.transform.childCount;
        //arranges pipes in pipes array
        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
