
# Changelog  
  
| modName    | SpaceY Expanded (SYX)                                             |
| ---------- | ----------------------------------------------------------------- |
| license    | CC-BY-NC-SA-4.0                                                   |
| author     | NecroBones and zer0Kerbal                                         |
| forum      | (https://forum.kerbalspaceprogram.com/index.php?/topic/211576-*/) |
| github     | (https://github.com/zer0Kerbal/SpaceYExpanded)                    |
| curseforge | (https://www.curseforge.com/kerbal/ksp-mods/SpaceYExpanded)       |
| spacedock  | (https://spacedock.info/mod/89)                                   |
| ckan       | SpaceYExpanded                                                    |

## Version 1.4.99.1-prerelease - `<Thank you NecroBones>` edition

* Released
  * 12 May 2023
  * for KSP 1.12.5
  * by [zer0Kerbal](https://github.com/zer0Kerbal)

### Change Summary

* 42/42 parts are now included
  * parts are fully localized (English) included actions
  * Phase I,II,III passes completed
    * parts pass started (see 1.4.99.0 for more details)
    * DRAG_CUBES, cargo, node, tags pass yet to complete
  * Parts updated (and included in this (pre)release)
    * Fairings
    * FuelTanks
    * Heatshields
    * Structural
    * ThrustPlates
    * CargoBays
    * Command
    * Control
    * Coupling
    * Engines
* NEW - Category fix [SpaceY.Expanded.dll] v1.4.99.3 - thank you [Lisias](https://github.com/Lisias)
* Compatibility patches have been updated, not tested.
* NEW - [BUG] BFR tank issues - just doesn't look pretty

* 📌 Pinned
  * Dependencies:
    * [SpaceY Corporation (SYC)](https://www.curseforge.com/kerbal/ksp-mods/SpaceYCorp)
    * [SpaceY Lifters (SYL)](https://www.curseforge.com/kerbal/ksp-mods/SpaceYLifters)
  * search for `syx` or `spacey` in the editor search bar to find all parts in this pack.
  * <ghostparts.cfg> is provided for testing.
    * This file will not be active for v1.5.0.0-release.
    * Can be disabled/deleted if installing this addon into a new save

### Changes 1.4.99.1

### Parts 1.4.99.1

* Update
  * Bays
    * [syx-bay-375]
    * [syx-bay-500]
    * [syx-bay-750]
  * Command
    * [syx-probe-750]
  * Control
    * [syx-vernier1]
  * Engines
    * [syx-eng-375-P1]
    * [syx-eng-550-P2]
    * [syx-eng-750-P4]
  * Fairings
    * [syx-fairing-1000]
    * [syx-fairing750]
  * Heatshields
    * [syx-heatShield-750]
  * Add
    * Control
      * [syx-vernier1.cfg]
    * Coupling
      * [syx-decoupler-1000.cfg]
      * [syx-decoupler-750.cfg]
      * [syx-separator-1000.cfg]
      * [syx-separator-750.cfg]
    * Engine
      * [syx-eng-375-E1.cfg]
      * [syx-eng-750-E2.cfg]
      * [syx-eng-750-E4.cfg]
      * [syx-eng-750-R9.cfg]
    * Fuel Tank
      * [syx-tank-1000-adapt-750.cfg]
      * [syx-tank-1000-L15000.cfg]
      * [syx-tank-1000-L22500.cfg]
      * [syx-tank-1000-L3750.cfg]
      * [syx-tank-1000-L7500.cfg]
      * [syx-tank-750-adapt-250.cfg]
      * [syx-tank-750-adapt-500.cfg]
      * [syx-tank-750-cone-1.cfg]
      * [syx-tank-750-L15000.cfg]
      * [syx-tank-750-L3750.cfg]
      * [syx-tank-750-L7500.cfg]
    * Structural
      * [syx-adapt-1000-375-X5.cfg]
      * [syx-adapt-1000-375-X7.cfg]
      * [syx-adapt-750-375-X4.cfg]
      * [syx-adapt-750-500.cfg]
    * Thrust Plates
      * [syx-plate-1000-125-X37.cfg]
      * [syx-plate-1000-125-X43.cfg]
      * [syx-plate-1000-375-X4.cfg]
      * [syx-plate-1000-750-X1.cfg]
      * [syx-plate-1000-X0.cfg]
      * [syx-plate-750-250-X7.cfg]
      * [syx-plate-750-375-X2.cfg]
      * [syx-plate-750-500-X1.cfg]
* closes #94 - [UPDATE] 'normalize' or 'stockalike' the part parameters
* closes #99 - Phase II - part update pass

### Assets 1.4.99.1

* Update
  * model (.mu) pointers
* [BUG] BFR tanks have texture issue
  * [syx-tank-1000-adapt-750.cfg]
  * [syx-tank-1000-L3750.cfg]
  * [syx-tank-1000-L7500.cfg]
  * [syx-tank-1000-L15000.cfg]
  * [syx-tank-1000-L22500.cfg]
* closes #9 - Part Asset Updates
* updates #104 - [BUG] BFR tanks have texture issue

### Compatibility 1.4.99.1

* Add
  * [MeshSwitch.cfg]
  * [RemoteTech.cfg]
* Update
  * [ModularFuelTanks.cfg]
  * [RemoteTech.cfg]
  * [TweakScale.cfg]
  * [0_TechTree.cfg]
  * [ActiveTextureManager.cfg.0]
  * [CommunityTechTree.cfg]
  * [ConnectedLivingSpace.cfg]
  * [CryoEngines.cfg]
  * [EngineIgnitor.cfg]
  * [HotRockets.cfg]
  * [MeshSwitch.cfg]

### Config 1.4.99.1

* Update
  * [CustomSounds.cfg]
  * [ghostparts.cfg]
  * [SpaceYExpanded.cfg]
  * [Variants.cfg]

### Localization 1.4.99.1

* Complete
  * part localization
* Update
  * Localization/
    * <en-us.cfg> v1.0.3.0
* closes #58 - Part Tags
* updates #39 - Localization - Master
* updates #40 - English <en-us.cfg>

### Code 1.4.99.1

* NEW - Category fix [SpaceY.Lifters.dll] v1.4.99.1
  * thank you [Lisias](https://github.com/Lisias)
  * https://github.com/zer0Kerbal/SpaceYLifters/issues/106#issuecomment-1426527352
* closes #105 - [BUG] Custom Category causing issues

### Issues 1.4.99.1

* closes #97 - SpaceY Expanded (SYE) 1.4.99.1-prerelease `<Thank you NecroBones>` edition
* closes #98 - 1.4.99.1 Additional Tasks

---

## Version 1.4.99.0-prerelease - `<Thank you NecroBones>` edition

* Released
  * 17 Jan 2023
  * for KSP 1.12.5
  * by [zer0Kerbal](https://github.com/zer0Kerbal)

### Adoption by [zer0Kerbal](https://github.com/zer0Kerbal)

### Summary 1.4.99.0

* This release is the first in a series of updates to this addon. Each update will update some of the parts and patches so that this addon can be updated in a more manageable manner instead of one massive update.
* Phase I (initial) pass
  * parts pass started (see 1.4.99.0 for more details)
* <ghostparts.cfg> is provided for testing.
  * This file will not be active for v2.0.0.0-release.
* Can now search for `sye` or `spacey` in the editor search bar to find parts in this pack.
* 42 total parts
  * Only updated parts are included
    * 11 parts newly updated
      * Bays
        * syx-serviceBay3m
        * syx-serviceBay5m
        * syx-serviceBay7m
      * Command
        * syx-probe7m
      * Control
        * syx-vernier1
      * Engines
        * syx-engine3mP1
        * syx-engine5mP2
        * syx-engine7mP4
      * Fairings
        * SYfairing10m
        * syx-fairing7m
      * Heatshields
        * syx-heatShield7m
  * 31 parts remain to be updated

### Changes 1.4.99.0

### Archival Releases 1.4.99.0

* Create
  * 1.4.0.0-release - KSP 1.4 update - `<Archival>`
  * 1.4.0.0-release - KSP 1.4 update - `<Archival>`
  * 1.3.1.0-release - Clean-up - `<Archival>`
  * 1.3.0.0-release - Update - `<Archival>`
  * 1.2.0.0-release - Update & KSP 1.2 compatibility - `<Archival>`
  * 1.1.11.0-release - Tweaks - `<Archival>`
  * 1.1.10.0-release - Tweaks - `<Archival>`
  * 1.1.9.0-release - Tweaks - `<Archival>`
  * 1.1.8.0-release - Tweaks - `<Archival>`
  * 1.1.7.0-release - Career fixes - `<Archival>`
  * 1.1.6.0-release - KSP 1.1 Update - `<Archival>`
  * 1.1.5.0-release - Tweaks - `<Archival>`
  * 1.1.4.0-release - Tweaks - `<Archival>`
  * 1.1.3.0-release - Fixes - `<Archival>`
  * 1.1.2.0-release - Fixes - `<Archival>`
  * 1.1.1.0-release - Fixes - `<Archival>`
  * 1.1.0.0-release - Texture Compatibility - `<Archival>`
  * 1.0.0.0-release - Stable - `<Archival>`
  * 0.9.0.0-release - KSP 1.0.5 update - `<Archival>`
  * 0.8.0.0-release - Beta, engine updates - `<Archival>`
  * 0.7.0.0-release - Beta - `<Archival>`
  * 0.6.1.0-release - Tweaks - `<Archival>`
  * 0.6.0.0-release - Beta - `<Archival>`
  * 0.5.1.0-release - Beta - `<Archival>`
  * 0.5.0.0-release - Beta - `<Archival>`
  * 0.4.0.0-release - Alpha/Beta - `<Archival>`
  * 0.3.0.0-release - Alpha/Beta - `<Archival>`
  * 0.2.0.0-release - Alpha/Bet - `<Archival>`
  * 0.1.0.0-release - Initial Alpha test version - `<Archival>`
* closes #7 - Archival Releases

### Compatibility 1.4.99.0

### Config 1.4.99.0

### Localization 1.4.99.0

* Create
  * Localization/
    * <en-us.cfg> v1.0.0.0
    * [readme.md] v2.1.2.0
    * [quickstart.md] v1.0.1.1
* Create
  * [SpaceYExpanded.cfg] v1.0.0.0
    * adds localized tags to parts
* closes #8 - Create Localization directory and contents
* closes #10 - Create <SpaceYExpanded.cfg>
* closes #40 - English <en-us.cfg>
* closes #57 - Part Localization
* updates #58 - Part Tags
* updates #39 - Localization - Master
  
### Parts 1.4.99.0

* Add
  * <ghostParts.cfg> v1.3.0.0
* Rename
  * parts to match naming scheme
    * replace `SY` with `syx-`
  * part files to match part names
* Fix
* Lint
* Reformat
* moved to SpaceY Corp
  * several localization strings
* Errors
  * closes #71 - [BUG] from archival releases
* Patches
  * Updated
    * filenames
    * Module Manger patch headers
    * file headers
    * general linting
  * applied patches supplied by forums
    * Penguin Patch applied
    * Vernier Patch applied
    * thank you to [linuxgurugamer](https://github.com/linuxgurugamer)
  * closes #62 - [PATCH] Vernier
  * closes #72 - [PATCH] Penguin Engines Thrust

### Assets 1.4.99.0

* create Assets/ folder
* convert
  * from mesh to MODEL
* rename
  * Rename model files to unique names
  * textures to unique names
* update
  * model pointers (.png et al to .dds)
  * model texture pointers to new names
* relocate assets to Assets/
* eliminate
  * remove duplicates textures/models
  * <SYadapter7m-Specular.dds> 1kb x3 3kb
  * <SYplate3m1m-Specular.dds> 1kb x2 2kb
  * <SYtank5m-Specular.dds> 1kb x4 x4 4kb
* relocate part.cfg to Parts/
* updates #9 - Part Asset Updates

### Documentation 1.4.99.0

* Add
  * GitHub Pages
    * [`_config.yml`]
    * [Attribution.md] v1.0.7.1
    * [ManualInstallation.md] v1.1.8.0
    * [404.md] v1.0.3.2
    * [LegalMumboJumbo.md] v1.0.5.1
    * [Localizations.md] v1.1.7.0
    * [Marketing.md] v1.0.1.0
    * [Notices.md] v1.0.1.0
    * [Part-Catalog.md] v1.1.4.1
    * [Why.md] v1.1.0.0
  * docs/thumbs
* closes #5 - Create GitHub Pages
* closes #6 - Create HeroLogo.png

### Cover image 1.4.99.0

* Create HeroLogo/Cover image
* closes #45 - Create HeroLogo.png

### Status 1.4.99.0

* Issues
  * closes #1 - SpaceY Expanded (SYX) 1.4.99.0-adoption `<Thank you NecroBones>` edition
  * closes #2 - 1.4.99.0 Create Legal Mumbo Jumbo
  * closes #3 - 1.4.99.0 Create Documentation
  * closes #4 - 1.4.99.0 Create Social Media Presence

---

## Version 1.4.0.0-Orvidius-CF-release - KSP 1.4 update

* 28 Jan 2022
* Released for Kerbal Space Program 1.8.1

### Status 1.4.0.0-Orvidius

* Maintenance Release

* Issues
  * updates #7 - Archival Releases
  * closes #38 - 1.4.0.0-release - `<KSP 1.4 update>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.4.0.0-release - KSP 1.4 update

* 02 Apr 2018
* Released for Kerbal Space Program 1.4.4

* Reworked color-changing to use KSP 1.4's mesh switcher.
* Flag decals disabled for now, since the stock mesh switcher doesn't play nicely with them.
* Disabled auto-caps on tanks, due to KSP bugs over several versions.
* Added some missing definitions for Modular Fuel Tanks.
* Changed ModularFuelTanks config to use consolidated wildcard patch.

### Status 1.4.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #38 - 1.4.0.0-release - `<KSP 1.4 update>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.3.1.0-release - Clean-up

* 03 Nov 2016
* Released for Kerbal Space Program 1.4.0

* Added "NEEDS" conditional for Connected Living Space patches, to clean up log spam.
* Consolidated the engine thrust transforms on the Penguin series engines.

### Status 1.3.1.0

* Issues
  * updates #7 - Archival Releases
  * closes #37 - 1.3.1.0-release - `<Clean-up>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.3.0.0-release - Update

* 18 Oct 2016
* Released for Kerbal Space Program 1.2.0

* Moved service bays to Payload tab.
* Added a pair of 10m-3.75m engine adapters.
* Added 10m stack separator.
* Added two new lengths of 10m fuel tanks.
* Added "SaturnV" paint scheme to 10m tanks to match new engine adapters.
* Removed some unnecessary duplicate geometry from 10m fuel tanks.

### Status 1.3.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #36 - 1.3.0.0-release - `<Update>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.2.0.0-release - Update & KSP 1.2 compatibility

* 12 Oct 2016
* Released for Kerbal Space Program 1.2.0

* Added KSP 1.2 and KerbNet modules to probe cores.
* Corrected a mesh alignment issue on the E1 Emu engine. 
* Added 10m parts, including some large thrust plates for SpaceX BFR/MCT/ITS styled lifters.
* Categories adjusted for several parts, corresponding to 1.2 changes.

### Status 1.2.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #35 - 1.2.0.0-release - `<Update & KSP 1.2 compatibility>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.11.0-release - Tweaks

* 01 Aug 2016
* Released for Kerbal Space Program 1.1.3

* Icon-only shroud added to fairing base, for easy identification in menu.
* Removed RemoteTech modules from probe core (now handled by patch in SpaceY-Lifters).
* Added a compatibility exclusion for HPTechTree.

### Status 1.1.11.0

* Issues
  * updates #7 - Archival Releases
  * closes #26 - 1.1.11.0-release - `<Tweaks>`

---

## Version 1.1.10.0-release - Tweaks

* 12 Jul 2016
* Released for Kerbal Space Program 1.1.3

* Restricted liquid fuel engines, fairings, and decouplers to non-surface part testing contracts, to match SRBs.
* Adjusted some nickname tags on engines.

### Status 1.1.10.0

* Issues
  * updates #7 - Archival Releases
  * closes #25 - 1.1.10.0-release - `<Tweaks>`

---

## Version 1.1.9.0-release - Tweaks

* 01 May 2016
* Released for Kerbal Space Program 1.1.0

* Updated Probe core to use IndicatorLights if available.
* Probe cores now also have a toggle option for light-up labels that correspond to the indicator lights.
* Converted many texture placeholders to DDS format (not that this gains much of anything).

### Status 1.1.9.0

* Issues
  * updates #7 - Archival Releases
  * closes #34 - 1.1.9.0-release - `<Tweaks>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.8.0-release - Tweaks

* 25 Apr 2016
* Released for Kerbal Space Program 1.1.0

* More search keywords on engines.
* Added collider setting for procedural fairing base.
* Updated heat shield's staging settings to match stock changes in 1.1.
* Fixed the "always transparent" problem in the VAB for the service/cargo bays.

### Status 1.1.8.0

* Issues
  * updates #7 - Archival Releases
  * closes #33 - 1.1.8.0-release - `<Tweaks>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.7.0-release - Career fixes

* 17 Apr 2016
* Released for Kerbal Space Program 1.1.0

* Drastically reduced career prices for fuel tanks, to bring them into line with stock again.
* Adjusted career prices of E1,E2,E4,R9 engines, to bring them into line with stock again.
* Increased prices on Penguin (P-series) engines.

### Status 1.1.7.0

* Issues
  * updates #7 - Archival Releases
  * closes #32 - 1.1.7.0-release - `<Career fixes>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.6.0-release - KSP 1.1 Update

* 31 Mar 2016
* Released for Kerbal Space Program 1.1.0

* Moved ModuleManager patches to "Patches" folder.
* Added tags for part searches.
* Updated ModuleManager inclusion.

### Status 1.1.6.0

* Issues
  * updates #7 - Archival Releases
  * closes #31 - 1.1.6.0-release - `<KSP 1.1 Update>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.5.0-release - Tweaks

* 29 Jan 2016
* Released for Kerbal Space Program 1.0.5

* Updated the CryoEngines config to be consistent with its new propellant ratio.

### Status 1.1.5.0

* Issues
  * updates #7 - Archival Releases
  * closes #30 - 1.1.5.0-release - `<Tweaks>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.4.0-release - Tweaks

* 14 Jan 2016
* Released for Kerbal Space Program 1.0.5

* Removed the tech tree nodes, since they've been moved to SpaceY Lifters (requires SpaceY Lifters 1.8.2+).

### Status 1.1.4.0

* Issues
  * updates #7 - Archival Releases
  * closes #29 - 1.1.4.0-release - `<Tweaks>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.3.0-release - Fixes

* 11 Jan 2016
* Released for Kerbal Space Program 1.0.5

* CryoEngines fix: The Penguin engines should no longer display their default plume effects even when not running.

### Status 1.1.3.0

* Issues
  * updates #7 - Archival Releases
  * closes #28 - 1.1.3.0-release - `<Fixes>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.2.0-release - Fixes

* 02 Jan 2016
* Released for Kerbal Space Program 1.0.5

* CryoEngines fix: The Penguin engines should no longer run more than one engine mode at once.

### Status 1.1.2.0

* Issues
  * updates #7 - Archival Releases
  * closes #27 - 1.1.2.0-release - `<Fixes>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.1.0-release - Fixes

* 02 Jan 2016
* Released for Kerbal Space Program 1.0.5

* Included ModuleManager version updated with its 2.6.16 bugfix update.
* Added a "needs" condition for TweakScale patches.

### Status 1.1.1.0

* Issues
  * updates #7 - Archival Releases
  * closes #24 - 1.1.1.0-release - `<Fixes>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.1.0.0-release - Texture Compatibility

* 31 Dec 2015
* Released for Kerbal Space Program 1.0.5

* Removed 7.5m fuel tank texture, since it was moved to SpaceY Lifters.
  * Repointed all necessary texture assignments to the new location.
  * Adjusted UV-mapping of 5m texture as needed to corrospond to changes in Lifters.
* Changed "ModularFuelTanks" config to also apply if RealFuels is installed.

### Status 1.1.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #23 - 1.1.0.0-release - `<Texture Compatibility>`
  * updates #71 - [BUG] from archival releases

---

## Version 1.0.0.0-release - Stable

* 17 Dec 2015
* Released for Kerbal Space Program 1.0.5

* Let's call this the 1.0 release. Things have been pretty stable lately.
* Added "SpaceY_ATM.cfg" with settings to attempt to disable or dissuade ActiveTextureManagement for this mod.
  * Can optionally be deleted to return to ATM defaults.
  * ATM known to occasionally have caching issues with remapped/shared textures in my mods.
  * SpaceY is already very memory efficient and uses DDS, so ATM doesn't help much for this case.
  * May need to delete ATM's cache if using ATM and some textures still aren't appearing.
* Updated 7.5m stack decoupler:
  * Ejection charge reduced by half (to 500, down from 1000).
  * Added built-in "sepratron" solid propellant separator motors.
  * Research cost increased slightly.
* Replaced "placeholder" textures. Smaller, and more obvious when texture reassignment has failed.
* Corrected a texture assignment problem on the 7.5m E2 engine.

### Status 1.0.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #22 - 1.0.0.0-release - `<Stable>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.9.0.0-release - KSP 1.0.5 update

* 11 Nov 2015
* Released for Kerbal Space Program 1.0.5

* Corrected the display-name of the "Gigantic Structure" tech node, instead of displaying it as a second "Massive Structure" node.
* Diameters added to 7.5m fuel tank names, for easy identification in VAB menu.
* Updated heat shield to current stock ablator settings and contract constraints. Slightly increased ablator quantity.
* Updated all engines to use FXModuleAnimateThrottle for heat animation.
* Engines, fairings, decouplers/separators updated to use new stock-alike thermal settings and contract constraints.
* Lightened the color and "grain" of the white texture on fuel tanks (will also affect 5m tanks).

### Status 0.9.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #21 - 0.9.0.0-release - `<KSP 1.0.5 update>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.8.0.0-release - Beta, engine updates

* 16 Oct 2015
* Released for Kerbal Space Program 1.0.4

* Adjusted R9 engine HotRockets config to correspond to SpaceY Lifters' fixes (as of Lifters v1.3).
* R9 engine now uses custom default engine effects from SpaceY Lifters (requires Lifters v1.3+).
* R9 engine now uses new engine bell art assets from SpaceY Lifters 1.3+.
* New default custom particle effects for LFO engines (E,P series).

### Status 0.8.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #20 - 0.8.0.0-release - `<Beta, engine updates>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.7.0.0-release - Beta

* 09 Oct 2015
* Released for Kerbal Space Program 1.0.4

* Corrected the cross-section profile on several parts (mainly Emu engines and decoupler/separators).
* Fuel tanks now have multiple paint schemes, selectable if InterstellarFuelSwitch or Firespitter are installed.
  * Known issue: Will have nasty z-fighting with all paint schemes at once, if something tricks ModuleManager about Interstelar/Firespitter installed state. Might have to delete ModuleManager config cache.

### Status 0.7.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #19 - 0.7.0.0-release - `<Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.6.1.0-release - Tweaks

* 02 Oct 2015
* Released for Kerbal Space Program 1.0.4

* Moved some engine mod-support to their own MM config files:
  * CryoEngines
  * EngineIgnitor
* Adjusted the Penguin engines' CryoEngines-triggered ISPs upward for both fuel modes.
* Added 7.5m stack separator.

### Status 0.6.1.0

* Issues
  * updates #7 - Archival Releases
  * closes #18 - 0.6.1.0-release - `<Tweaks>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.6.0.0-release - Beta

* 01 Oct 2015
* Released for Kerbal Space Program 1.0.4

* Adjusted P-series (Penguin) engines back to 400 ISP by default.
* Added MM config for Penguin engines to detect CryoEngines and make the following tweaks:
  * Reduces Liquid-Fuel ISP to 360.
  * Adds mode switching, with alternate Liquid-Hydrogen mode, with slightly better ISP but slightly worse thrust.
* Added a minuscule gimbal range to Penguin engines (previously they were non-vectoring).
* Significantly increased connection breaking strength on most parts (including all 7.5m parts).

### Status 0.6.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #17 - 0.6.0.0-release - `<Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.5.1.0-release - Beta

* 23 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Adjusted P-series (Penguins) vacuum ISP to 390. Work in progress. :)
* Fixed a problem with the 7.5m tanks (and 5m tanks) working properly with Modular Fuel Tanks.

### Status 0.5.1.0

* Issues
  * updates #7 - Archival Releases
  * closes #16 - 0.5.1.0-release - `<Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.5.0.0-release - Beta

* 23 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Fixed an issue with some parts not being able to show up in CTT's tech tree. Requires SpaceY-Lifters v1.0.4 to be effective.
* Corrected the names of the README and this CHANGELOG to reflect that it's the Expanded version of the mod.
* Reduced P-series (Penguins) vacuum ISP to 380 (down from 400).

### Status 0.5.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #15 - 0.5.0.0-release - `<Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.4.0.0-release - Alpha/Beta

* 11 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Added 7.5m service bay.
* Corrected the 3.75m and 5m service bays to have "No Attach" flag for door colliders.
* Reduced the size of the flag decal on the 5m service bay.

### Status 0.4.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #14 - 0.4.0.0-release - `<Alpha/Beta>`
  * updates #71 - [BUG] from archival releases
  * updates #71 - [BUG] from archival releases

---

## Version 0.3.0.0-release - Alpha/Beta

* 10 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Added service bays: 3.75m, 5m
* Fixed a typo in the TweakScale config.

### Status 0.3.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #13 - 0.3.0.0-release - `<Alpha/Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.2.0.0-release - Alpha/Beta

* 04 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Increased the 1-atmosphere ISP of the Penguin (vacuum) engines to 250, up from 100.
* Changed the E1 engine's thrust vector location to aid in clipping engines.
* Added fueled 7.5m nose cone.
* 7.5m to 5m adapter tank more than doubled in capacity, cost, etc (was underpowered for its size)
  * Also added it to the Modular Fuel Tanks config.
* Added an additional shorter 7.5m to 5m adapter tank with checkered paint scheme.
* Added non-fueled 7.5m to 5m adapter.
* Emu" engine. stage capable 7.5m "Dual Added an upper

### Status 0.2.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #12 - 0.2.0.0-release - `<Alpha/Beta>`
  * updates #71 - [BUG] from archival releases

---

## Version 0.1.0.0-release - Initial Alpha test version

* 02 Sep 2015
* Released for Kerbal Space Program 1.0.4

* Requires ModuleManager and SpaceY-Lifters as dependencies.

### Status 0.1.0.0

* Issues
  * updates #7 - Archival Releases
  * closes #11 - 0.1.0.0-release - `<Initial Alpha test version>`
  * updates #71 - [BUG] from archival releases

---