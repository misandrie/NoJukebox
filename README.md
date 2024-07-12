Disables playing any audiofiles if its coming from the Jukebox.

What why
1. Jukebox is an [old PR](https://github.com/space-wizards/space-station-14/pull/20418) that was later [revived](https://github.com/space-wizards/space-station-14/pull/26736) and [selfmerged](https://github.com/space-wizards/space-station-14/commit/2db374988c91c6ce5f932b9cee1ba251cbfb22e5) by sloth
2. Jukebox does [not give a single solitary fuck about volume settings](https://github.com/space-wizards/space-station-14/issues/27981), only subordinate to master volume
3. Due to AudioSystem jank (post-rework btw) - Audio entities from [jukebox do not care if it's paused or not](https://github.com/space-wizards/space-station-14/issues/28901)
4. Additionally due to AudioSystem jank - the jukebox's audio [is played in PVS range on server](https://github.com/space-wizards/space-station-14/blob/c94c72785df97e7a98097a0bc4733e998e4454a8/Content.Server/Audio/Jukebox/JukeboxSystem.cs#L58) and thus quite a bitch to do volume control for

Requires referenced game dll's to compile.
