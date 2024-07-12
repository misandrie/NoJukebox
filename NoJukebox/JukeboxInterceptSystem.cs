using Content.Shared.Audio.Jukebox;
using Robust.Shared.Audio.Components;
using Robust.Shared.GameObjects;

public class JukeboxInterceptSystem : EntitySystem
{
    public bool CameFromJukebox(AudioComponent comp)
    {
        var query = EntityQueryEnumerator<JukeboxComponent>();

        while (query.MoveNext(out EntityUid ent, out JukeboxComponent? jukebox))
        {
            if (!TryComp(jukebox.AudioStream, out AudioComponent? audio)) continue;
            
            if (audio == comp)
                return true;
        }

        return false;
    }
}