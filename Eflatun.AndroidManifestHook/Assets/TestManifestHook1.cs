using Eflatun.AndroidManifestHook;

public class TestManifestHook2 : AndroidManifestHooker
{
    protected override void Modify(AndroidManifest androidManifest)
    {
        var elem = androidManifest.SetAttributeWithAndroidNamespace(androidManifest.ApplicationElement, "foo2", "bar2");
    }
}
