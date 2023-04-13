using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _viewText;
    
    public void SetNewValue(int scores)
    {
        _viewText.text = scores.ToString();
    }
}
