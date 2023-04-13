using UnityEngine;

[CreateAssetMenu(fileName = "BallScriptableObject", menuName = "ScriptableObject/Ball", order = 2)]
public class BallScriptableObject : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _score;
    [SerializeField] private BallColor _ballColor;

    public Sprite Sprite => _sprite;
    public BallColor BallColor => _ballColor;
    public int Score => _score;
}
