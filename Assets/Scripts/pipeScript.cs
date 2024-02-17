using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };

    public float correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;

    private void Start()
    {
        
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0,0, rotations[rand]);

        if(PossibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotation)
            {
                isPlaced = true;
            }
            else
            {
                if (transform.eulerAngles.z == correctRotation)
                {
                    isPlaced = true;
                }
            }

        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (PossibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotation && isPlaced == false)
            {
                isPlaced = true;
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation && isPlaced == false)
            {
                isPlaced = true;
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
            }
        }
            
    }
}
// BUGS: some pieces make you move them to get to "solved" even if they are already in the correct location
//       vertical piece never solves
    //      last corner piece never solves

//my implementation: if is solved light up at the point with the music. 