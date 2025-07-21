using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class foodBudget : MonoBehaviour
{
    public Button _buttonAdd;
    public TMP_Text _price;
    public static int balanceAmount;
    public static int foodPrice;


    void Start()
    {

    }

    public void CheckSelectedItem()
    {

        ColorBlock cb = _buttonAdd.colors;
        cb.selectedColor = Color.green;

        _buttonAdd.colors = cb;

        foodPrice = int.Parse(_price.text);

        balanceAmount = tripPlanner.budgetAmount - foodPrice;

        tripPlanner._instance.UpdatePlan();

    }
}
