using UnityEngine;

public abstract class Condition : ScriptableObject
{
    [SerializeField]
    private string description;

    public abstract bool IsPass(Quest quest);
}
