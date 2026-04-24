using Renderite.Shared;
using Renderite.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineLoadProgress : EngineInitProgress
{
    bool initStarted;
    public bool Done;
    public float LoadProgress { get; private set; }

    public override void InitStarted()
    {
        initStarted = true;
    }

    public override void InitCompleted()
    {
        Done = true;
    }

    public override void UpdateProgress(Renderite.Shared.RendererInitProgressUpdate update)
    {
    }
    public override void ApplySplashScreenOverride(RendererSplashScreenOverride splashScreen)
    {
    }
}
