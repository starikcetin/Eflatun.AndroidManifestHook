# Eflatun.AndroidManifestHook
Utilites for hooking into AndroidManifest.xml generation.

## Installation

1. Get this: https://github.com/mob-sakai/UpmGitExtension

2. Install this repo from Unity Package Manager window, inside Unity.

## Usage

```cs
using Eflatun.AndroidManifestHook;

public class TestManifestHook : AndroidManifestHooker
{
    protected override void Modify(AndroidManifest androidManifest)
    {
        var value = androidManifest.SetAttributeWithAndroidNamespace(androidManifest.ApplicationElement, "foo", "bar");
    }
}
```

The code above will result in this:
```xml
<application ... android:foo="bar">
```

You need to create an asmdef file with:

1. only Editor platform selected 
2. a reference to Eflatun.AndroidManifestHook asmdef

for your manifest hooker scripts. Otherwise you will get build errors. 

It should look like this:

![asmdef screenshot](https://raw.githubusercontent.com/starikcetin/Eflatun.AndroidManifestHook/repo-res/asmdef.png)

## License

MIT license. Refer to the [LICENSE](/LICENSE) file.

Copyright (c) 2019 S. Tarık Çetin.
