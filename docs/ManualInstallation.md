---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---
<!-- ManualInstallation.md v1.5.0.0
SpaceY Expanded (SYX)
created: 17 Jan 2023
updated: 11 May 2023

TEMPLATE: ManualInstallation.md v1.1.9.1
created: 01 Feb 2022
updated: 26 Apr 2023

based upon work by Lisias -->

## [SpaceY Expanded (SYX)][mod]

[Home](./index.md)

An expansion pack for the SpaceY Heavy Lifters mod. **This pack requires SpaceY Corp (SYC), SpaceY Expanded (SYX), and ModularManagement to be installed as dependencies.**

Adds 7.5m parts, plus additional engines, accessories, and other parts that go beyond the original stated purpose of SpaceY Heavy Lifters.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `SpaceY` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SpaceY/SpaceYExpanded`
* Extract the package's `SpaceY` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/SpaceY/` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/SpaceY/SpaceYExpanded`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SpaceY/SpaceYExpanded`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/SpaceY/SpaceYExpanded`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [SpaceY]
      + [SpaceY Corporation (SYC)][SYC]
        ...
      + [SpaceYLifters][SYL]
        ...
      + [SpaceYExpanded][SYX]
        + [Assets]
          ...
        + [Category]
          ...
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Contracts]
          ...
        + [FX]
          ...
        + [Localization]
          ...
        + [Parts]
          ...
        + [Plugins]
          ...
        ...
        * #.#.#.#.htm
        * Attributions.htm
        * CC-BY-NC-SA-4.0.txt
        * changelog.md
        * ManualInstallation.htm
        * readme.htm
        * SpaceYExpanded.version
      ...
    ...
    * [ModularManagement][MM] or [Module Manager][omm]
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* [SpaceY Corporation (SYC)][SYC]
* [SpaceY Expanded (SYX)][SYL]
* [ModularManagement][MM] or [Module Manager][omm]

[MM]: https://www.curseforge.com/kerbal/ksp-mods/ModularManagement "ModularManagement (MM)"
[omm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[SYC]: https://www.curseforge.com/kerbal/ksp-mods/SpaceYCorp "SpaceY Corporation (SYC)"
[SYL]: https://www.curseforge.com/kerbal/ksp-mods/SpaceYLifters "SpaceY Lifters (SYL)"

THIS FILE: CC BY-ND 4.0 by [zer0Kerbal](https://github.com/zer0Kerbal)
  used with express permission from zer0Kerbal

[mod]: https://www.curseforge.com/kerbal/ksp-mods/SpaceYExpanded "SpaceY Expanded (SYX)"
