using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Renderite.Shared;
using Renderite.Unity;

public class WindowDriver : WindowInput
{
#if UNITY_STANDALONE_WIN
    public override void UpdateState(WindowState state)
    {
        base.UpdateState(state);;
    }

    void Awake()
    {
    }

    void OnDroppedFiles(List<string> aPathNames)
    {
    }
#endif
}
