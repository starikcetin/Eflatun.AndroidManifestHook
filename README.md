# Eflatun.AndroidManifestHook
Utilites for hooking into AndroidManifest.xml generation.

# Installation

Get this: https://github.com/mob-sakai/UpmGitExtension
Install this repo from Unit Package Manager window, inside Unity.

# Usage

    using Eflatun.AndroidManifestHook;

    public class TestManifestHook : AndroidManifestHooker
    {
        protected override void Modify(AndroidManifest androidManifest)
        {
            var elem = androidManifest.SetAttributeWithAndroidNamespace(androidManifest.ApplicationElement, "foo", "bar");
        }
    }

The code above will result in this:

    <application ... android:foo="bar">
