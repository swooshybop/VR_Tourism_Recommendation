using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class tripPlanner : MonoBehaviour
{
    public static int budgetAmount;

    public TMP_Dropdown dropdown1;
    public TMP_Text resultText;
    public TMP_Text spentAmount;
    public TMP_Text remainingAmount;

    public static tripPlanner _instance;

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        dropdown1.onValueChanged.AddListener(delegate { UpdateSum(); });
    }

    void UpdateSum()
    {
        int value1 = int.Parse(dropdown1.options[dropdown1.value].text);

        resultText.text = "Budget: " + value1.ToString();

        budgetAmount = value1;

        UpdatePlan();
    }

    public void UpdatePlan()
    {
        remainingAmount.text = "Remaining: " + (budgetAmount - roomBudget.roomPrice - transportBudget.transportPrice - foodBudget.foodPrice - shopBudget.shopPrice);
        spentAmount.text = "Spent: " + (roomBudget.roomPrice + transportBudget.transportPrice + shopBudget.shopPrice + foodBudget.foodPrice);
    }
}
