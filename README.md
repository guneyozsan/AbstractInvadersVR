**NOTE:** Development of this game continues [here](https://github.com/postillusions/abstract-invaders-vr) at [Post Illusions](https://github.com/postillusions).

# Abstract Invaders VR

**Defend your Pyramid Planet from Invader Cubes coming from a mysterious space portal. Meanwhile listen to the soothing radio waves you generated.**

Made during [Global Game Jam 2017](https://globalgamejam.org/) at [BAU BUG Game Lab](http://buglab.bau.edu.tr/) site in Istanbul. This year's theme was "Waves".

## How to play

### Controls

* Put your VR headset on (Gear VR, Cardboard, Oculus, HTC Vive).
* Play only by looking around, no buttons to push. Green radio waves are emitted from the point you gaze at the portal gate throughout the portal.
* `Back` button or `Esc` key restarts the level.

### Gameplay

* Keep your Pyramid Planet behind safe by preventing Invader Cubes from reaching the portal gate.
* Use your Radio Wave Emitter to hit and drag Invader Cubes approaching from the portal marked with blue lines.
* If Invader Cubes reach the portal gate they turn red which means they manage to pass your defenses and invade your Pyramid Planet (The less reds the better you are).

## Notes on Implementation

The radio wave emitter emit waves from where the player gazes at the portal gate throughout the portal tunnel. In order to implement this, an invisible raycast target plane is placed at the portal gate. Waves are emitted from where we gaze on this invisible raycast target. That point is determined by a raycast sent from player camera to the portal gate. This way the waves can be emitted throughout the portal rather than forming an arc of waves spreading all around the space centered at the player.

One concern for this design decision was that a first-person-shooter/turret-like feeling was not preferable. Spreading waves throughout a tunnel gives a better visualization of waves which matches the game jam theme "Waves" better.

Another concern was to create a better perception of perspective by spreading the waves throughout the portal tunnel resulting in a better immersive depth feeling for a VR game.

## Notes on Sound Design

In order to support the game jam theme "Waves", the X and Y coordinates of the radio wave source act as frequency multipliers for two separate Sin waves generated and sent to the left and right audio output each. Similar to two [Theremins](https://en.wikipedia.org/wiki/Theremin) each played by one of the X and Y coordinates.

## License

"Abstract Invaders" is a trademark of Guney Ozsan.

Abstract Invaders VR - Defend your Pyramid Planet from Invader Cubes coming from a mysterious space portal.
Copyright (C) 2018 Guney Ozsan

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.

## Credits

Game design, development, graphics and sound design by [Guney Ozsan](http://www.guneyozsan.com).

Game born at [Global Game Jam 2017](https://globalgamejam.org/).
