using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //Funcion para cargar el primer nivel
   public void LoadLevel1()
   {
       SceneManager.LoadScene("Super mario");
   }

   public void LoadMenuPrincipal()
   {
       SceneManager.LoadScene("Menu principal");
   }
   

      
}
