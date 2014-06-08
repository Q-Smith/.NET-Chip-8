# .NET CHIP-8

CHIP-8 is an interpreted programming language, developed by Joseph Weisbecker. It was initially used on the COSMAC VIP and Telmac 1800 8-bit microcomputers in the mid-1970s. CHIP-8 programs are run on a CHIP-8 virtual machine. It was made to allow video games to be more easily programmed for said computers.

Reference: http://en.wikipedia.org/wiki/CHIP-8

## Overview

In a time of Virtual Machines and Mobile Phone Emulators, I really wondered what it would be like to develop an emulator.  Since I needed something simple to start with, I found CHIP-8 had the simplest intruction set totally only 35 Opcodes.

The purpose of this project was for me to learn a little bit about CHIP-8 and how to implement an interpreter to run CHIP-8 ROM's. It was a great experience which brought me back to basic with regards to better understanding a machines Memory and CPU (in its simplest form).

## Goals

* Load a CHIP-8 ROM.
* Implement Pseudo-Assembly to understand intruction set
* Understand and display the Font.
* Emulator the game loop at the correct speed
* Implement Keyboard handling
* Implement a Keyboard mapping view
* Implement Sound beeps
* Be able to pause the game.

## ROM's

Working ROM's:
- [X] Pong
- [X] Tetris
- [X] Breakout
 
## Known Issues

* The game loop timing I think needs a little more attention.
* The mapping of the keyboard keys has a bug. Sometimes a key is not registered and therefore you're not able to move in that direction.

## Other Links

* http://www.chip8.com/
* http://www.emulator101.com/
* http://mattmik.com/chip8.html
* http://www.pong-story.com/chip8/
* http://devernay.free.fr/hacks/chip8/C8TECH10.HTM
