using UnityEditor.Android;
using UnityEngine;

namespace Eflatun.AndroidManifestHook
{
    public abstract class AndroidManifestHooker : IPostGenerateGradleAndroidProject
    {
        public int callbackOrder => 1;
        public void OnPostGenerateGradleAndroidProject(string path)
        {
            var className = this.GetType().UnderlyingSystemType.Name;

            Debug.Log($"AndroidManifestHooker ({className}): Modifying AndroidManifest.xml file.");
            var manifestPath = Utils.GetManifestPath(path);
            var androidManifest = new AndroidManifest(manifestPath);
            Modify(androidManifest);
            androidManifest.Save();
        }

        protected abstract void Modify(AndroidManifest androidManifest);
    }
}
