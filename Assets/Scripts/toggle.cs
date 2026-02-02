using UnityEngine;

public class toggle : MonoBehaviour
{
   public void Toggle()
    {
        Debug.Log("Toggle the object");
        //gameObject.SetActive(false); //SetActive sets the value 
        //gameObject.activeInHierarchy //this tells us if the box is ticked 

        //if the object is active, call set active and pass false
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
        //else
        //{
        //    gameObject.SetActive(true);
        //}
        //otherwise, call set active and pass true

        gameObject.SetActive(!gameObject.activeInHierarchy); 
    }
}
