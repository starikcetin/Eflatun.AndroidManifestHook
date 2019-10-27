using Eflatun.AndroidManifestHook;

public class TestManifestHook : AndroidManifestHooker
{
    protected override void Modify(AndroidManifest androidManifest)
    {
        var elem = androidManifest.SetAttributeWithAndroidNamespace(androidManifest.ApplicationElement, "foo", "bar");
    }
}
