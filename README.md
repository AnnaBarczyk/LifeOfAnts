# LifeOfAnts
Console project.

In an Ant colony there are four different castes: Workers, Soldiers, Drones, and there is one Queen.<br/>
<br/>
For the sake of simplicity let they live on a grid. Ants have an actual ( x , y ) position (initialize these within the limits of the colony, e.g. 100 steps).<br/>
They change their positions in each timestep, according to a caste-specific rule:<br/>
The Queen sits in the origo and does not move.<br/>
All the Ants are aware of their distance from the Queen which is the number of steps needed to get to her (write a function for it!).<br/>
The Workers normally make one step randomly in one of the four directions.<br/>
The Soldiers normally just “patrol” close to their starting points; this means that in a 4-cycle they step one towards North, then East, South, and West, and then they start the cycle again.<br/>
The Drones always try to make one step towards the Queen. When they get 3 steps close, they have a chance that the Queen is in the mood of mating. In this happy case they say “HALLELUJAH”, stay there for 10 timesteps, and after that they are kicked off to a random point with the distance of 100 steps. If they do not have luck, they say “D’OH”, and are kicked 100 steps away instantly.<br/>
The Queen’s mating mood is following this rule: after a successful mating she sets a countdown timer (starting from some time between 100 and 200 timesteps) to get in the mood again. Tip: at first you can skip this part and set the Queen’s mood randomly.<br/>
Extra feature: Sometimes a Wasp appears in the colony. In this case all movements freeze in the colony except that the Soldiers start to move towards the Wasp. The first Soldier to get there says “HAJIME” and kills the intruder. All the ants continue with their normal activities.<br/>

#Project Goals: <br/>
-should have an abstract class <br/>
-use inheritance<br/>
-data hiding<br/>
-no code repetition<br/>

#Status<br/>
Completed
