
# Changelog  
  
| modName    | SpaceY Expanded (SYE)                                             |
| ---------- | ----------------------------------------------------------------- |
| license    | CC-BY-NC-SA-4.0                                                   |
| author     | NecroBones and zer0Kerbal                                         |
| forum      | (https://forum.kerbalspaceprogram.com/index.php?/topic/211576-*/) |
| github     | (https://github.com/zer0Kerbal/SpaceYExpanded)                    |
| curseforge | (https://www.curseforge.com/kerbal/ksp-mods/SpaceYExpanded)       |
| spacedock  | (https://spacedock.info/mod/89)                                   |
| ckan       | SpaceYExpanded                                                    |

## Version 1.4.0.0 - KSP 1.4 update

* 02 Apr 2018

* Reworked color-changing to use KSP 1.4's mesh switcher.
* Flag decals disabled for now, since the stock mesh switcher doesn't play nicely with them.
* Disabled auto-caps on tanks, due to KSP bugs over several versions.
* Added some missing definitions for Modular Fuel Tanks.
* Changed ModularFuelTanks config to use consolidated wildcard patch.

---

## Version 1.3.1.0 - Clean-up

* 03 Nov 2016

* Added "NEEDS" conditional for Connected Living Space patches, to clean up log spam.
* Consolidated the engine thrust transforms on the Penguin series engines.

---

## Version 1.3.0.0 - Update

* 18 Oct 2016

* Moved service bays to Payload tab.
* Added a pair of 10m-3.75m engine adapters.
* Added 10m stack separator.
* Added two new lengths of 10m fuel tanks.
* Added "SaturnV" paint scheme to 10m tanks to match new engine adapters.
* Removed some unnecessary duplicate geometry from 10m fuel tanks.

---

## Version 1.2.0.0 - Update & KSP 1.2 compatibility

* 12 Oct 2016

* Added KSP 1.2 and KerbNet modules to probe cores.
* Corrected a mesh alignment issue on the E1 Emu engine. 
* Added 10m parts, including some large thrust plates for SpaceX BFR/MCT/ITS styled lifters.
* Categories adjusted for several parts, corresponding to 1.2 changes.

---

## Version 1.1.11.0 - Tweaks

* 01 Aug 2016

* Icon-only shroud added to fairing base, for easy identification in menu.
* Removed RemoteTech modules from probe core (now handled by patch in SpaceY-Lifters).
* Added a compatibility exclusion for HPTechTree.

---

## Version 1.1.10.0 - Tweaks

* 12 Jul 2016

* Restricted liquid fuel engines, fairings, and decouplers to non-surface part testing contracts, to match SRBs.
* Adjusted some nickname tags on engines.

---

## Version 1.1.9.0 - Tweaks

* 01 May 2016

* Updated Probe core to use IndicatorLights if available.
* Probe cores now also have a toggle option for light-up labels that correspond to the indicator lights.
* Converted many texture placeholders to DDS format (not that this gains much of anything).

---

## Version 1.1.8.0 - Tweaks

* 25 Apr 2016

* More search keywords on engines.
* Added collider setting for procedural fairing base.
* Updated heat shield's staging settings to match stock changes in 1.1.
* Fixed the "always transparent" problem in the VAB for the service/cargo bays.

---

## Version 1.1.7.0 - Career fixes

* 17 Apr 2016

* Drastically reduced career prices for fuel tanks, to bring them into line with stock again.
* Adjusted career prices of E1,E2,E4,R9 engines, to bring them into line with stock again.
* Increased prices on Penguin (P-series) engines.

---

## Version 1.1.6.0 - KSP 1.1 Update

* 31 Mar 2016

* Moved ModuleManager patches to "Patches" folder.
* Added tags for part searches.
* Updated ModuleManager inclusion.

---

## Version 1.1.5.0 - Tweaks

* 29 Jan 2016

* Updated the CryoEngines config to be consistent with its new propellant ratio.

---

## Version 1.1.4.0 - Tweaks

* 14 Jan 2016

* Removed the tech tree nodes, since they've been moved to SpaceY Lifters (requires SpaceY Lifters 1.8.2+).

---

## Version 1.1.3.0 - Fixes

* 11 Jan 2016

* CryoEngines fix: The Penguin engines should no longer display their default plume effects even when not running.

---

## Version 1.1.2.0 - Fixes

* 02 Jan 2016

* CryoEngines fix: The Penguin engines should no longer run more than one engine mode at once.

---

## Version 1.1.1.0 - Fixes

* 02 Jan 2016

* Included ModuleManager version updated with its 2.6.16 bugfix update.
* Added a "needs" condition for TweakScale patches.

---

## Version 1.1.0.0 - Texture Compatibility

* 31 Dec 2015

* Removed 7.5m fuel tank texture, since it was moved to SpaceY Lifters.
  * Repointed all necessary texture assignments to the new location.
  * Adjusted UV-mapping of 5m texture as needed to corrospond to changes in Lifters.
* Changed "ModularFuelTanks" config to also apply if RealFuels is installed.

---

## Version 1.0.0.0 - Stable

* 17 Dec 2015

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

---

## Version 0.9.0.0 - KSP 1.0.5 update

* 11 Nov 2015

* Corrected the display-name of the "Gigantic Structure" tech node, instead of displaying it as a second "Massive Structure" node.
* Diameters added to 7.5m fuel tank names, for easy identification in VAB menu.
* Updated heat shield to current stock ablator settings and contract constraints. Slightly increased ablator quantity.
* Updated all engines to use FXModuleAnimateThrottle for heat animation.
* Engines, fairings, decouplers/separators updated to use new stock-alike thermal settings and contract constraints.
* Lightened the color and "grain" of the white texture on fuel tanks (will also affect 5m tanks).

---

## Version 0.8.0.0 - Beta, engine updates

* 16 Oct 2015

* Adjusted R9 engine HotRockets config to correspond to SpaceY Lifters' fixes (as of Lifters v1.3).
* R9 engine now uses custom default engine effects from SpaceY Lifters (requires Lifters v1.3+).
* R9 engine now uses new engine bell art assets from SpaceY Lifters 1.3+.
* New default custom particle effects for LFO engines (E,P series).

---

## Version 0.7.0.0 - Beta

* 09 Oct 2015

* Corrected the cross-section profile on several parts (mainly Emu engines and decoupler/separators).
* Fuel tanks now have multiple paint schemes, selectable if InterstellarFuelSwitch or Firespitter are installed.
  * Known issue: Will have nasty z-fighting with all paint schemes at once, if something tricks ModuleManager about Interstelar/Firespitter installed state. Might have to delete ModuleManager config cache.

---

## Version 0.6.1.0 - Tweaks

* 02 Oct 2015

* Moved some engine mod-support to their own MM config files:
  * CryoEngines
  * EngineIgnitor
* Adjusted the Penguin engines' CryoEngines-triggered ISPs upward for both fuel modes.
* Added 7.5m stack separator.

---

## Version 0.6.0.0 - Beta

* 01 Oct 2015

* Adjusted P-series (Penguin) engines back to 400 ISP by default.
* Added MM config for Penguin engines to detect CryoEngines and make the following tweaks:
  * Reduces Liquid-Fuel ISP to 360.
  * Adds mode switching, with alternate Liquid-Hydrogen mode, with slightly better ISP but slightly worse thrust.
* Added a minuscule gimbal range to Penguin engines (previously they were non-vectoring). 
* Significantly increased connection breaking strength on most parts (including all 7.5m parts).

---

## Version 0.5.1.0 - Beta

* 23 Sep 2015

* Adjusted P-series (Penguins) vacuum ISP to 390. Work in progress. :)
* Fixed a problem with the 7.5m tanks (and 5m tanks) working properly with Modular Fuel Tanks.

---

## Version 0.5.0.0 - Beta

* 23 Sep 2015

* Fixed an issue with some parts not being able to show up in CTT's tech tree. Requires SpaceY-Lifters v1.0.4 to be effective.
* Corrected the names of the README and this CHANGELOG to reflect that it's the Expanded version of the mod.
* Reduced P-series (Penguins) vacuum ISP to 380 (down from 400).

---

## Version 0.4.0.0 - Alpha/Beta

* 11 Sep 2015

* Added 7.5m service bay.
* Corrected the 3.75m and 5m service bays to have "No Attach" flag for door colliders.
* Reduced the size of the flag decal on the 5m service bay.

---

## Version 0.3.0.0 - Alpha/Beta

* 10 Sep 2015

* Added service bays: 3.75m, 5m
* Fixed a typo in the TweakScale config.

---

## Version 0.2.0.0 - Alpha/Bet

* 04 Sep 2015

* Increased the 1-atmosphere ISP of the Penguin (vacuum) engines to 250, up from 100.
* Changed the E1 engine's thrust vector location to aid in clipping engines.
* Added fueled 7.5m nose cone.
* 7.5m to 5m adapter tank more than doubled in capacity, cost, etc (was underpowered for its size)
  * Also added it to the Modular Fuel Tanks config.
* Added an additional shorter 7.5m to 5m adapter tank with checkered paint scheme.
* Added non-fueled 7.5m to 5m adapter.
* Emu" engine. stage capable 7.5m "Dual Added an upper

---

## Version 0.1.0.0 - Initial Alpha test version

* 02 Sep 2015

* Requires ModuleManager and SpaceY-Lifters as dependencies.

---