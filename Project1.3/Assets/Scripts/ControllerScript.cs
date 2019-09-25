using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    int bronze = 0;
    int silver = 0;
    int bronzeSupply = 3;
    int silverSupply = 2;
    float mineNow;
    float miningSpeed = 3;
    public GameObject redPrefab;
    public GameObject silverPrefab;
    public Vector3 cubePosition;
    int xPos = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        mineNow = miningSpeed;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > mineNow)
        {
            mineNow += miningSpeed;

            if (bronzeSupply > 0)
            {
                bronze++;
                bronzeSupply--;
                cubePosition = new Vector3(xPos, 0, 0);
                Instantiate(redPrefab, cubePosition, Quaternion.identity);
                xPos+=2;
            }
            else if (silverSupply > 0)
            {
                silver++;
                silverSupply--;
                cubePosition = new Vector3(xPos, -2, 0);
                Instantiate(silverPrefab, cubePosition, Quaternion.identity);
                xPos-=2;
            }
            print("Bronze:" + bronze + " Silver:" + silver);
        }

    }
}
