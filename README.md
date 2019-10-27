# Eflatun.AndroidManifestHook
Utilites for hooking into AndroidManifest.xml generation.

# Installation

1. Get this: https://github.com/mob-sakai/UpmGitExtension

2. Install this repo from Unity Package Manager window, inside Unity.

# Usage

    using Eflatun.AndroidManifestHook;

    public class TestManifestHook : AndroidManifestHooker
    {
        protected override void Modify(AndroidManifest androidManifest)
        {
            var value = androidManifest.SetAttributeWithAndroidNamespace(androidManifest.ApplicationElement, "foo", "bar");
        }
    }

The code above will result in this:

    <application ... android:foo="bar">
