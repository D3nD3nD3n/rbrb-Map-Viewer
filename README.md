# rbrb-Map-Viewer
https://ci.appveyor.com/project/D3nD3nD3n/rbrb-map-viewer/build/artifacts

Read and edit Rabi-Ribi map data in memory. Currently supports all versions in the beta tab as well as 1.80 as of 8/30/2017.

COLLISION_TILES.png and TILE1_A.png must be placed inside either the RabiRibiMapViewer folder or in the same folder as the .exe

Memory addresses are picked according to which version the program detects.  The game version is detected by checking for "BUNNY EX" and for Cocoa's event spawn ID at their expected addresses.  Failure to get a proper match from both checks will prevent any memory changes.  In the unlikely event where the map tab cell colors are incorrect or the collision tab is showing random collisions, assume everything else is bad.

Save tab checks for exact file size of 2,602,708 bytes and that the file ends in ".map".  Please don't find an important file that is exactly 2,602,708 bytes, rename it to end in .map, then save over it.

## Tab special notes

Map tab: Load Memory button must be used after reloads or changing map.

Room tab: Primarily for entities and items.
