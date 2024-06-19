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
        deactivateAll();


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(currentIndex<comida.Length-1)
            {
                currentIndex++;
                deactivateAll();
                activateByIndex();
            }
            else
            {
                currentIndex = 0;
                deactivateAll();
                activateByIndex();
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            if(currentIndex>0)
            {
                currentIndex--;
                deactivateAll();
                activateByIndex();
            }
            else
            {
                currentIndex = 19;
                deactivateAll();
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
        comida[currentIndex].SetActive(true);
    }

    void deactivateAll()
    {
        for (int i = 0; i <= comida.Length-1; i++)
        {
            comida[i].SetActive(false);
        }
    }

}
