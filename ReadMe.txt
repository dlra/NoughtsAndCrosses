Noughts and Crosses Game
Daniel Ansell
22/10/2021

==========

Aim: To create a Noughts And Crosses game in the form of a simple console application

Notes:
- Looking to give good testing coverage so will write unit tests after a TDD fashion

Features
- Added some startup code
- the game is a high-level abstaction which manages the fundamental aspects of a game,
i.e., starting stopping, setting up etc.
- the game runner manages the progress of the game
- the game board printer is used whenever game visualisation is required
- Abstracted use of the console into an interface to allow for enhanced testability

Current state
- Need to add more unit tests to probe recent new services added

Observations
- Got a bit bogged down on writing set up code when really I used have concentrated more on
a stripped down version that could be ran and allowed functioning play

Future steps
- Update unit tests
- Complete the adding of basic functionality to allow the game to run