using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luna.Unity;

public class UIC_ChooseShip : MonoBehaviour
{
    static string Ev_Select_Ship_1 = "Phantom";
    static string Ev_Select_Ship_2 = "Frigus";
    public void ChooseButton_Ship_1()
    {
        gameObject.SetActive(false);
        Ply_Level.Ins.ship.ChangeShip(ShipType.Ship_1); 
        Ply_Level.Ins.Play();
        Analytics.LogEvent(Ev_Select_Ship_1, 1);
    }

    public void ChooseButton_Ship_2()
    {
        gameObject.SetActive(false);
        Ply_Level.Ins.ship.ChangeShip(ShipType.Ship_2);
        Ply_Level.Ins.Play();
        Analytics.LogEvent(Ev_Select_Ship_2, 1);
    }
}
