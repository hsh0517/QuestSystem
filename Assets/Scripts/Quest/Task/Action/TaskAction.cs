using UnityEngine;

public abstract class TaskAction : ScriptableObject
{
    public abstract int Run(Task task, int currentSuccess, int successCount);
}
