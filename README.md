# Abstract-Invaders-VR

Made during Global Game Jam 2017 at BAU BUG Game Lab site in Istanbul. This year's theme was "Waves".

Defend your pyramid shaped planet from Invader Cubes. Use your radio wave emitter to push them back. Don't let them get close to you, become red and invade your pyramid shaped planet. Meanwhile listen to the calming radio waves you generated.

How to play:

Put your (Gear VR, Cardboard, Oculus, HTC Vive) headset on.
Invader Cubes are attacking from a portal marked with blue lines. Push back the Invader Cubes by hitting them with your radio waves
Keep safe your pyramid shaped world standing at your back.
Play with only look, no buttons. Green radio waves are emitted from the point you look through the portal.
"Back" button or "Esc" key restarts the level.
Notes on Game Design: The waves are emitted from the hit point of the raycast from camera on an invisible square plane in the beginning of the portal. The waves need to spread in parallel to the portal rather than an arc centered at the player, and also a turret-like feeling was not preferable and having a different starting point then the camera displays the wave formations better in perspective.

Note on sound design: The X and Y coordinates of the radio wave source also acts as parameters for frequencies of a Sin wave generated at the left and right audio output, like a double Theremin.

Game design, development, graphics and sound design by Guney Ozsan.

Game born at Global Game Jam 2017.
