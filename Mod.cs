using MelonLoader;
using UnityEngine;

namespace ExampleMod
{
    public class Mod : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("ExampleMod chargé !");
            MelonLogger.Warning("Ceci est un message de warning.");
        }

        public override void OnUpdate()
        {
            // Exemple de déclenchement avec une touche
            if (Input.GetKeyDown(KeyCode.F1))
            {
                MelonLogger.Msg("Touche F1 appuyée !");
            }
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            MelonLogger.Msg($"Scene initialisée : {sceneName} (buildIndex {buildIndex})");
        }
    }
}