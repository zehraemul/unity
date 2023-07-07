using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw2 : MonoBehaviour
{
    // Start is called before the first frame update
    void bolenleriBul(int ilkSayi, int sonSayi)
    {
        string listString = "tum liste ";
        string listString2 = "ikiye bolunenlerin listesi ";
        string listString3 = "uce bolunenlerin listesi ";
        string listString4 = "dorde bolunenlerin listesi ";
        string listString5 = "bese bolunenlerin listesi ";
        /* foreach(int i in list)
         {
             listString += i;

         }*/

        for (int i = ilkSayi; i <= sonSayi; i++)
        {
            listString += " " + i;
            if(i % 2 == 0)
            {
                listString2 += " " + i;
            } if(i % 3 == 0)
            {
                listString3 += " " + i;
            }
             if (i % 4 == 0)
            {
                listString4 += " " + i;
            }
             if (i % 5 == 0)
            {
                listString5 += " " + i;
            }

        }

        print(listString);
        print(listString2);
        print(listString3);
        print(listString4);
        print(listString5);
       

    }


   // int[] list = { 1, 2, 3, 4, 5 }; //c# list olusturma kodu.
    void Start()
    {
        bolenleriBul(5, 26);
        /*string listString = "";
        foreach(int i in list)
        {
            listString += " " + i;
        }
        print(listString);*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
