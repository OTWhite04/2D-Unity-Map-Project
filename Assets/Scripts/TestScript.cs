using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string Word = "Word";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The Variable is {Word}"); 
        
        if(Word == "Word")
        {
            Debug.Log("The Variable is Word");
        }
        else 
        {
            Debug.Log("The Variable isn't Word");
        }

        for(int i = 0; i < 11; i++)
        {
            Word = ($"{Word} {i}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    




}
