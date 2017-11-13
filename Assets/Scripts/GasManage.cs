using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class GasManage : MonoBehaviour {

    public Button gasUseButton;
    public Button gasBuyButton;
    public Button addsBuyButton;
    public Button unlimitedGasButton;

    public Text gasValue;
    public int gasCount = 5;

    public Text addsValue;
    public int addsCount = 1;

    void Start()
    {
        gasValue.text = gasCount.ToString();
        addsValue.text = addsCount.ToString();

        Button gasUse = gasUseButton.GetComponent<Button>();
        gasUse.onClick.AddListener(UseGas);
        Button gasBuy = gasBuyButton.GetComponent<Button>();
        gasBuy.onClick.AddListener(BuyGas);
        Button addsBuy = addsBuyButton.GetComponent<Button>();
        addsBuy.onClick.AddListener(BuyAdds);
        Button unlimitedGasBuy = unlimitedGasButton.GetComponent<Button>();
        unlimitedGasBuy.onClick.AddListener(BuyUnlimitedGas);
    }
	
    void UseGas()
    {
        Debug.Log("gas use");
        --gasCount;
        gasValue.text = gasCount.ToString();
    }

    void BuyGas()
    {
        Purchaser.purchaser.BuyConsumable();
        
        Debug.Log("gas buy");
        gasCount += 5;
        gasValue.text = gasCount.ToString();
    }

    void BuyAdds()
    {
        Purchaser.purchaser.BuyNonConsumable();
        
        Debug.Log("adds buy");
        addsCount = 0;
        addsValue.text = addsCount.ToString();
    }

    void BuyUnlimitedGas()
    {
        Purchaser.purchaser.BuySubscription();

        Debug.Log("ulimited gas one minuted");
        gasValue.text = "FULL";
    }
}
