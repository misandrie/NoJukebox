using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Robust.Client.Audio;
using Robust.Shared.Audio.Components;
using Robust.Shared.GameObjects;
using Robust.Shared.IoC;

[HarmonyPatch(typeof(AudioSystem), "OnAudioStartup")]
public static class NoJukebox
{
    private static JukeboxInterceptSystem? _intercept;

    [HarmonyPrefix]
    public static bool AudioStartupPrefix(AudioComponent component)
    {
        _intercept ??= IoCManager.Resolve<IEntityManager>().System<JukeboxInterceptSystem>();

        return !_intercept.CameFromJukebox(component);
    }
}