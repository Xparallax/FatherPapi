# FatherPapi
 ## Scripts

### Ally

this script is for the christian children therefore from the database "swarm" it was made so it would not harm the player however would attack any object with the tag enemy.

there is also a refrence of the Enemy database for the ally to have health and damage and it has a script for the sprite/animation to flip right or left depending on the direction of said object.

### AttackArea

this script is for the "kick" the player does to attack, it makes it that if it is triggered the player will attack any object with has the enemy tag when both 2D objects collide with eachother.


### DestroyBullet 

is a script for the bibles that the player throws, it makes it that when the player spawns said bibles it does not damage the player when it collides with them, however it will damage any other object, the gameobject will destroy itself in two seconds and has 30 damage in refrence to the health script.

### DestroyWithDelay 

the script refrences that any object with the tag "Enemy" will destroy itself in 20 seconds, this is also added on God

### Enemy 

this is a script for enemies with refrences the Enemy database for health/damage/speed, it also suggests that any object with the tag "player" will result in the gameobject to follow and attack it 

### EnemyData

it is a scriptable object where it refrences a database to have a public int for the health,damage and speed of the database created this is the enemy database that is refrenced in other scripts and it is also the database in the folder "Enemies"

### EnemySpawner 

this is for the spawnpoints and it sets an interval of how long it takes to spawn the object, the prefab's object that it spawns. for example one of the spawnpoints spawns the prefab for "God" every 30 seconds. this is a script that can be added twice if not more on a single object depending on how many items you want to spawn in the same area.

### Fire 

Fire is another script for when the player throws bibles, it states that when the player presses "Q" the bibles will spawn and be thrown at the direction the player is facing, however the player cannot collect anymore than 3 and it also links to the UI as every time the player collects a bible, a buble from the UI appears.

### GameAudio 

this suggests that the game usually plays the normal theme however when god spawns it switches to his theme.

### GameOver 

this is for the gameover scene where there are two buttons "restart" puts the user back in the game where mainmenu would put the user in the mainmenu scene.

### God 

this is a script for one object only which states that it follows the player, when it spawns it switches to the god audio and when it gets destroyed it switches to the normal one, the object has the same database as others for the health/speed and damage.

### Heal 

this is for the loot that when it collides with anything that has the tag "Player" it will increase it's health.

### Health 

this scripts states that when any object gets something that increases their health they would turn green, however if something damages them they turn red. this is linked with the batebase as if an objects health turns into the negatives they get destroyed therefore they drop a loot.

### Invulenerability

this is for the player where if they get hit by anything with the tag "Enemy" then their layer collison will be ignored for a few seconds and will look transparent.

### KillPlayer

if an object with the tag "Player" gets destoryed it will change to the Gameover scene.

### Load 

this is for the cutscene where if it reaches 40 seconds it goes to the game scene or if the user presses space.

### Loot 

this is a scriptable object where it shows the lootname and the dropchance.

### LootBag 

lootbag helps with how the loot drops.

### LootHeal 

as the name states when the object has the tag "Player" it will heal them, the loot will also despawn at a specific time.

### MainMenu

when the user clicks on "play" it will go to the next scene, if the player clicks on "Quit" it will quit the game.

### Movebackground 

this is for the background to have a parallex effect where it will move the direction of where the camera is moving and will generate at a specific time.

### PlayerMovement 

this is how the player moves and how the player jumps, it also states about when the player flips the sprite flips with the object.

### PlayerAttack 

this states that when the player presses "E" the player attacks by spawning an attack area, it also states that when the player presses "E" the attack animation starts.

### PlayerHealth 

when the player dies and it goes to the gameover scene and shows that the player has died.

### ShowUI

this is for the instructions where it will spawn only when the scene starts and will distroy itself when it passes 10 seconds.
