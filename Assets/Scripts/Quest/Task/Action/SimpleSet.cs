using UnityEngine;

[CreateAssetMenu(menuName = "Quest/Task/Action/SimpleSet", fileName = "Simple Set")]
public class SimpleSet : TaskAction
{
    public override int Run(Task task, int currentSuccess, int successCount)
    {
        return successCount;
    }
}
