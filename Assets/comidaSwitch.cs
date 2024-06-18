using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comidaSwitch : MonoBehaviour
{
    public  GameObject[] comida;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= comida.Length; i++)
        {
            comida[i].SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if(currentIndex<comida.Length)
            {
                deactivateByIndex();
                activateByIndex();
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if(currentIndex>-1)
            {
                deactivateByIndex();
                activateByIndex();
            }
        }
    }
    void deactivateByIndex()
    {
            comida[currentIndex].SetActive(false);
    }
    void activateByIndex()
    {
        comida[currentIndex+1].SetActive(true);
    }
}
