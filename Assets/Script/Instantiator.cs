using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmmount;
    public GameObject objectToClone;
    int cloneammount;
    GameObject clon; 


    public void MultiInstantiate()
    {

        if (txtUserCloneAmmount.text != "")
        {
            cloneammount = int.Parse(txtUserCloneAmmount.text);
        }

        for (int i =0; i<cloneammount;i++ )
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);
        }
    }
}
