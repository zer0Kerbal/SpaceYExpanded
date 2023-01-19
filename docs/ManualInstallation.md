---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- ManualInstallation.md v1.1.8.1
SpaceY Expanded (SYE)
created: 01 Oct 2019
updated: 29 Jul 2022 -->

<!-- based upon work by Lisias -->

# SpaceY Expanded (SYE)

[Home](./index.md)

An expansion pack for the SpaceY Heavy Lifters mod. **This pack requires SpaceY Corp (SYC), SpaceY Lifters (SYL), and Module Manager to be installed as dependencies.**

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
      + [SpaceYExpanded][SYE]
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Contracts]
          ...
        + [Localization]
          ...
        + [Parts]
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
    ...
    * [Module Manager /L][mml] or [Module Manager][mm]
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* [SpaceY Corporation (SYC)][SYC]
* [SpaceY Lifters (SYL)][SYL]
* either
  * [Module Manager /L][mml]
  * [Module Manager][mm]

[SYC]: https://forum.kerbalspaceprogram.com/index.php?/topic/209446-*/ "SpaceY Corporation (SYC)"
[SYL]: https://forum.kerbalspaceprogram.com/index.php?/topic/209445-*/ "SpaceY Lifters (SYL)"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
