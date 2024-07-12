using HarmonyLib;

public static class SubverterPatch
{
    public static string Name = "NoJukebox";
    public static string Description = "Disables jukebox audio output on client.";
}


public static class MarseyEntry
{
    public static void Entry()
    {
        Harmony harm = new Harmony("Misandrie.NoJukebox");

        harm.PatchAll();
    }
}