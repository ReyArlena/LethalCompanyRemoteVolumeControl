# RemoteVolumeControl for Lethal Company

A mod for Lethal Company allowing you to change the client-side volume of all Boomboxes from anywhere on the map.

This is a fork of the [boombox volume control](https://thunderstore.io/c/lethal-company/p/Inoyu/boombox_volume_control/) mod with two small differences:

* Default keybinds are `[` and `]` instead of `o` and `p`.
* Volume change increments are `10%` instead of `20%`.

Big thanks to [Inoyu](https://thunderstore.io/c/lethal-company/p/Inoyu/) for creating the [boombox volume control](https://thunderstore.io/c/lethal-company/p/Inoyu/boombox_volume_control/) mod, which helped me greatly in figuring out how all this stuff works, and provided 99% of the code for this fork. 

I take no credit for this mod, I only made some small modifications :)

## Default Keybinds

Below are the default keybinds. They can be changed in the normal keybind settings if you wish.

* Volume Down = `[` (Left Square Bracket)
* Volume Up = `]` (Right Square Bracket)

## Installation

This mod **requires** [BepInEx](https://thunderstore.io/c/lethal-company/p/BepInEx/BepInExPack/) and [InputUtils](https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/).

Use a mod manager ([r2modman](https://thunderstore.io/c/lethal-company/p/ebkr/r2modman/) is highly recommended), it will handle everything for you.

If you wish to install this manually, place the `.dll` in your `BepInEx\plugins` after installing the above requirements.

## Compatibility

This mod is intended for use with [DiscJockey](https://thunderstore.io/c/lethal-company/p/Yoshify/DiscJockey/), however should work with any other Boombox mod (or even just the vanilla Boombox).

If you are using other mods that use the keybinds for `[` and `]`, you will need to rebind the keys for this mod or your other one.

## Changelog

### v1.0.0

* Ability to control all client-side Boombox volumes on the map from wherever you are (in increments of 10%)
* Ability to remap the keybinds

## Issues

If you have any issues, please submit them on the GitHub page.