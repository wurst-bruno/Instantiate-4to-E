using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmmount;
    public GameObject objectToClone;
    int cloneammount;

    public void MultiInstantiate()
    {

        if (txtUserCloneAmmount.text != "")
        {
            Debug.Log(int.Parse(txtUserCloneAmmount.text) * 2);
        }

        cloneammount = int.Parse(txtUserCloneAmmount.text);
        int counter = 0;

        while (counter < cloneammount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
