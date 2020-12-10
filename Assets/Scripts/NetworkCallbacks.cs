using UnityEngine;
using Bolt;

public class NetworkCallbacks : GlobalEventListener
{
    public GameObject cubePrefab;

    public override void SceneLoadLocalDone(string scene)
    {
        //var spawnPos = new Vector3(72, -7, 36);

        //BoltNetwork.Instantiate(cubePrefab, spawnPos, Quaternion.identity);
    }
}
