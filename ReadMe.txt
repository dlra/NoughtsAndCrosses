Noughts and Crosses Game
Daniel Ansell
22/10/2021

==========

Aim: To create a Noughts And Crosses game in the form of a simple console application

Notes:
- Looking to give good testing coverage so will write unit tests after a TDD fashion

Features
- the 'game' is a high-level abstaction which manages the fundamental aspects of a game,
i.e., starting stopping, setting up etc.
- the 'game runner' manages the progress of the game
- the 'game board printer' is used whenever game visualisation is required
- Abstracted use of the console into an interface to allow for enhanced testability
- 'Options selector' to process player option selection on their turn
- 'Selection processor' to process that selection
- 'Game adjudicator' to decide whether the game has finished and advise players of the result

Current state
- Game runs
- Still need to add more unit tests to probe recent new services added
- Not yet at production level

Observations
(22/10/21)
- Got a bit bogged down on writing set up code when really I used have concentrated more on
a stripped down version that could be ran and allowed functioning play
(10/11/21)
- Have used SOLID principles to keep individual classes lean, semantic and purposeful

Future steps
- Add more unit tests