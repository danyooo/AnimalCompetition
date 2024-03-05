# AnimalCompetition
An ICS4U Assignment
Contributer edit the document [here](https://docs.google.com/document/d/1U9jMFjn_aXgzKeLX-VEsJbIc4vT_vvxj2GAW7LH0W_k/edit?usp=sharing)
# AnimalCompetition            
Dany & Norby
# *Chimera Faceoff*

# General Idea
Game is a pokemon-esque style. Pit two chimeras against each other and fight until one peacefully falls asleep. These Chimeras possess a fighting-strength that will increase or decrease based on their attributes, and whether or not they got attributes that aligned well to an environment(i.e flippers would give a low fighting strength, but if the island subtype was chosen it would rather give a much higher strength due to the presence of water). This fighting strength attribute would apply multipliers to pre existing values of AttackPower,Defense,Mobility,Etc. For example, Flippers would have a relatively low mobility chance UNLESS they were in water, at that point they would have a multiplier applied to increase that chance(+3.00x mobility for example). In contrast, something like wings may get a debuff if they fall into water or get wet(-2.00x) .  

You can only assign one attribute per part, and will cycle through them (Eyes
Attributes will have a point-style system as they are chosen. There will be positive attributes and negative attributes. The player will have a point-pool to begin with (i.e 10 points), and each positive attribute( bonus-granting) will decrease that pool, and each negative attribute will give points to that pool.

Animals will have unique attributes such as eyesight(night-vision, movement-based etc.) These values will determine how well a chimera , skin (scales, fur, etc for protection values). Certain attributes can be applied multiple times to different parts of the body (head,arms,torso,legs,tail if it applies). 

There will be random-aspects such as weather, and environment type. This randomness is to challenge the player, with certain ‘parts’ being more advantageous in certain environments or situations, but then sacrificing that advantage in others. This is to encourage the player not to make an entirely tanky, large character that would win every time because it is not too adaptable and would lose in the wrong type of environment. The challenge is to try to make an adaptable creature that would fare well in all types of environments, whilst being under the restriction of a point pool.
Player begins with x Points in the pool



# Attributes
There are general attributes that will be added or subtracted from statically depending on the parts that constitute a chimera. These parts that constitute a chimera will have multipliers depending on the conditions they are in. (Environment handles the multiplier/check rather than the part itself. Check Environment section to view modifiers)

**Values are subject to change.** 

# General Attributes
* Mobility(Affects Dodge Chance)
* Defense(Affects hit absorption,amount of health)
* Attack(Affects attack damage, Attack Rate)
* Sight(Affects chance to successfully hit target,can add or remove from Mobility)

## List of eye-related modifiers
* Night vision eyes(Buffs sight slightly,costs 4 points)
* Eagle eyes(Buffs sight greatly, costs 10 points)
* Near sighted/Far sightedness(Lowers sight at certain ranges, gives player 6 points)

## List of Mouth Related modifiers
* Herbivore teeth(Decreases attack by 2, 4 points gained)
* Carnivore teeth(Increases attack by 4, costs 5 points?)
* Omnivore teeth(Increases attack by 2 costs 3 points)

## List of skin related modifiers
* Fur(Increased defense by 3, costs 5 points)
* Slimy skin(Defense decreased by 4, increased mobility by 2 unless in wet weather, then buffs mobility greatly, costs 5 points)
* Scales (Defense increased by 6, mobility decreased by 3, costs 7 or 6 points)

## List of feet related modifiers
* Webbed feet(Slightly decreased mobility on land, increased mobility in water costs 3-5 points)
* Hooved Feet(Buff mobility on rocky rough terrain costs 4 or 5 points, increased defense by 2)
* Pawed feet(Increased mobility by 3, decreased defense by 4, costs 4 or 5 points)


## Other modifiers
**Hands** 
* Claws(Increased Attack Power by 4 or 5
* Fingered hands(Increased defense by 4, lowered attack by 3, costs 6 or 5 points)
**Extra Limbs**
* Wings (Increased mobility by 5, decreased defense by 4, if in water, decrease mobility by 5, costs 7 points)
* Tail (Increased sight by 3, costs 4 points)



# Environment
The environment will be completely randomized, and  to make the player(s) have to configure an animal to better suit their environment each playthrough.(They will not know what the environment is, its up to the player to either build their chimera towards adaptability or to build their animal to suit one particular environment.

## List of  MAIN TYPES OF environments(; Plains, Mountains, beach, ) These will be deterministic factors of which subtype is chosen. These main types are more so categories from which a specific environment will be chosen(i.e If you get a beach environment, go to the subtype list and choose a random one. Let’s say you get an island.)

### List of SUB types of environments( Sub meaning they fall under a broader category of environments) ; 
**Mountain subtypes**
* Ravine(Wing types apply a buff to mobility )
* Peak of mountain(Cold, fur gets a slight buff to defense  scaly skin gets debuff to defense)
* Cliffside(Hoofed feet mobility buff)
* Volcano(scale skin defense buff)
**Plains Subtypes**
* Forest (Decreases vision slightly other than eagle eyed chimera)
* Cave(Dark vision applies a buff) 
* Hills(No buffs/debuffs, plain fighting grounds)
* Small lake/river (Buffs swimming chimera’s mobility)

**Beach subtypes**
* Rocky beach(Hurts certain feet affecting mobility/dodge), 
* Desert(Hot, affects energy OR hurts feet)
* Island(Reduced mobility //dodge for chimeras a little bit, unless semi aquatic[Webbed feet?], then keep the same mobility #.)




## Weather/Time(Randomized)


* Rain(Reduces mobility multiplier of furred organisms, increases mobility multiplier of slimy-skinned animals) 
* Sunny
* Night Time(Positively multiplies sight at night time), 
* Winter/snowing(Increased attack rate with pawed chimeras, lowered hooved attack rate.) 
* Hailing(1 or 2 damage per tick/second)




## Base values
The base values would be:
Point Pool(15 Points. May change as needed in testing)

Base Chimera Values(Seeing as the modifiers apply via multiplication)
* Mobility:5
* Defense:5
* Attack:5
* Sight:5

  
**These values may change in testing**



## Possible Future Goals
* Jungle(Optional, buffs climbing/clawed or sticky hands/stealth)

