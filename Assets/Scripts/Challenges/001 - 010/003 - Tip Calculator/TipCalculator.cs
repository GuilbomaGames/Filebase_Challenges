using UnityEngine;

namespace Challenges
{
    public class TipCalculator : MonoBehaviour
    {
        //Variable for the calculated tip
        // Variable for the bill
        // Variable Variable for 15% tip
        // Variable Variable for 20% tip
        // Variable Variable for 25% tip
        // Variable Variable for custom% tip
        // calculate the custom tip and the total bill.

        [SerializeField] private float dinnerBill = 20.0f;
        private float _tip15;
        private float _tip20;
        private float _tip25;
        [SerializeField] private float tipCustom;
        private float _tipCustomCalculated;
        
        private float _totalSum15;
        private float _totalSum20;
        private float _totalSum25;
        private float _totalSumCustom;
        
        private void Start()
        {
            _tip15 = dinnerBill * 0.15f;
            _tip20 = dinnerBill * 0.20f;
            _tip25 = dinnerBill * 0.25f;
            _tipCustomCalculated = dinnerBill * (tipCustom / 100f);

            _totalSum15 = dinnerBill + _tip15;
            _totalSum20 = dinnerBill + _tip20;
            _totalSum25 = dinnerBill + _tip25;
            _totalSumCustom = dinnerBill + tipCustom;
            
            Debug.Log($"15% tip = {_tip15}€ with a final total of {_totalSum15}");
            Debug.Log($"20% tip = {_tip20}€ with a final total of {_totalSum20}");
            Debug.Log($"25% tip = {_tip25}€ with a final total of {_totalSum25}");
            Debug.Log($"Your custom tip of {tipCustom}% = {_tipCustomCalculated}€ " +
                      $"with a final total of {_totalSumCustom}");
        }
    }
}
