# MG7
## Devlog
The TreeOfBirds script makes the birds come out of the tree when the player gets close to them. I used an array to store all the Sparrow GameObjects in the scene, except for Sparrow_Start. This makes it easier to control all the birds in one script. I can also add the birds to the array through the Unity Inspector. The script checks the distance between the player and each bird every frame. I used Vector3 to get the positions of the player and the birds, and Vector3.Distance() to calculate how far apart they are. If the player gets close enough to a bird, the script activates that bird's GameObject. This way, the birds automatically appear as the player walks closer to the tree.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
