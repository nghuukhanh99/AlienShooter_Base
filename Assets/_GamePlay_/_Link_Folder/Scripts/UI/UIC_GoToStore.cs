using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luna.Unity;

public class UIC_GoToStore : MonoBehaviour
{
   public void GoToStore()
   {
        LifeCycle.GameEnded();
        Playable.InstallFullGame();
   }
}
