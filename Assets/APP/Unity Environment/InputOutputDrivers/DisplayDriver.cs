using System.Collections.Generic;
using Renderite.Shared;
using Renderite.Unity;

public class DisplayDriver : DisplayInput
{
    public override IDisplayTextureSource TryGetDisplayTexture(int index)
    {
        return null;
    }

    protected override void UpdateState(List<DisplayState> states)
    {
    }
}
